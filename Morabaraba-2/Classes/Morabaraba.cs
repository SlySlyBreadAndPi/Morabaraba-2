using Morabaraba_2.Models;
using static Morabaraba_2.Models.ColorType;
using static Morabaraba_2.Models.Phases;
using Morabaraba_2.Helpers;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Morabaraba_2.Classes
{
    /// <summary>
    /// This class holds the current game session between two players
    /// </summary>

    public class Morabaraba
    {
        private Board CurrentBoard;
        private Player p1;
        private Player p2;
        private bool turn;
        private bool removing;
        PlayerCreator creator;
        GameBoardInitialisor init;
        ValidPositionVerifier verifier;

        /// <summary>
        /// Constructor
        /// </summary>
        public Morabaraba(Grid parent,Colour color)
        {
            init = new GameBoardInitialisor(parent);
            CurrentBoard = init.InitializeBoard();
            creator = new PlayerCreator(color);
            p1 = creator.GetPlayerOne();
            p2 = creator.GetPlayerTwo();
            turn = true;
            removing = false;

        }
        /// <summary>
        /// Initialises the Current Game Session Objects
        /// </summary>
        /// <param name="parent"></param>
        public void Init()
        {
           
           // currentGameState = new Game(init.InitializeBoard(),creator.GetPlayerOne(),creator.GetPlayerTwo());
        }
        /// <summary>
        /// Sets a node at a given index to a Cow and then checks for a valid mill
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool PlaceCow (int index)
        {
            CurrentBoard.SetNode(index, TurnCow());
            return (CurrentBoard.CheckIndexForMill(index, Turn()));
        }
        /// <summary>
        /// Move takes in a index of an ellipse and then uses the game state variables it has within it to call various methods to facilitate appropriate actions.
        /// </summary>
        /// <param name="index"></param>
        public Board Move (int index)
        {
            verifier = new ValidPositionVerifier(CurrentBoard);

            if(removing)
            {
                bool inMill = CurrentBoard.CheckIndexForMill(index, OtherPlayer());
                bool allInMill = !CurrentBoard.ContainsCowNotinMill(OtherPlayer());
                bool ownedByOpponent = verifier.VerifyOwnByPlayer(index, OtherPlayer());
                if (ownedByOpponent && (inMill == allInMill))
                {
                    CurrentBoard.SetEmpty(index);
                    CowKilled();
                    removing = false;
                    NextTurn();
                    
                }

                
            }
            else
            {
                switch (Turn().GetPhase())
                {
                    case (Phase.Moving):
                        if(verifier.VerifyOwnByPlayer(index, Turn())&& verifier.VerifyAdjacent(CurrentBoard.GetAdjacent(index)))
                        {
                            CurrentBoard.SetEmpty(index);
                            SetTurnPhase(Phase.Moving2);                            
                        }
                        break;
                    case (Phase.Moving2):
                        if (verifier.VerifyEmpty(index))
                        {
                            removing=PlaceCow(index);
                            SetTurnPhase(Phase.Moving);
                            if (!removing) NextTurn();
                        }
                        break;
                    case (Phase.Placing):
                        if (verifier.VerifyEmpty(index))
                        {
                            CowPlaced();
                            removing = PlaceCow(index);
                            if (!removing) NextTurn();
                        }
                        break;
                    case (Phase.Flying):
                        if (verifier.VerifyOwnByPlayer(index, Turn()))
                        {
                            CurrentBoard.SetEmpty(index);
                            SetTurnPhase(Phase.Flying2);
                        }
                        break;
                    case (Phase.Flying2):
                        if (verifier.VerifyEmpty(index))
                        {
                            removing = PlaceCow(index);
                            SetTurnPhase(Phase.Flying);
                            if (!removing) NextTurn();
                        }
                        break;
                }
            }

            return CurrentBoard;

        }
        /// <summary>
        /// Responsible for Making allowing the player to make a move 
        /// This method is the intermediary between the UI and 
        /// the rest of the game
        /// </summary>
        /// <param name="pos">The cow postion the Player whises to place a cow in</param>
        /// <param name="turn">Next Players turn</param>
        /// <returns></returns>

        /// <summary>
        /// Removes an opponents cow from the board
        /// </summary>
        /// <param name="ellipseClicked">Cow that was clicked on and to be removed</param>
        /// <param name="piecesParent">The Actual board i.e. human readable board</param>
        ///<param name="otherPlayer">used for checking if the other player has placed all they cows </param>


        /// <summary>
        /// Gets the Current state of the Board
        /// </summary>
        /// <returns> Board </returns>

        /// <summary>
        /// Returns a player 
        /// </summary>
        /// <param name="turn">Used for determining which player to return</param>
        /// <returns></returns>
        /// 
        public Player Turn() => turn ? p1 : p2;
        public Player OtherPlayer() => turn ? p2 : p1;
        public void CowPlaced()
        {
            if (turn) p1.PiecePlaced();
            else p2.PiecePlaced();
        }
        public void CowKilled()
        {
            if (!turn) p1.PieceKilled();
            else p2.PieceKilled();
        }
        public void NextTurn() { turn = !turn; }
        public void SetTurnPhase(Phase phase)
        {
            if (turn) p1.SetPhase(phase);
            else p2.SetPhase(phase);
        }
        public Cow TurnCow() => turn ? p1.GetCow() : p2.GetCow();


    }
}
