using MorabarabaNS.Models;
using static MorabarabaNS.Models.Phases;
using MorabarabaNS.Helpers;
using System.Collections.Generic;
using MorabarabaNS.Interfaces;

namespace MorabarabaNS.Classes
{
    /// <summary>
    /// This class holds the current game session between two players
    /// </summary>

    public class Morabaraba: IMorabaraba
    {
        private Board CurrentBoard;
        private Player p1;
        private Player p2;
        private bool turn;
        private bool removing;
        PlayerCreator creator;
        GameBoardInitialisor init;
        ValidPositionVerifier verifier;
        private ICommand command;

        /// <summary>
        /// Constructor
        /// </summary>
        public Morabaraba()
        {
            init = new GameBoardInitialisor();
            CurrentBoard = init.InitializeBoard();
            creator = new PlayerCreator(ColorType.Colour.Dark);
            p1 = creator.GetPlayerOne();
            p2 = creator.GetPlayerTwo();
            turn = true;
            removing = false;
            
        }

        public Morabaraba(ICommand command)
        {
            this.command = command;
            init = new GameBoardInitialisor();
            CurrentBoard = init.InitializeBoard();
            creator = new PlayerCreator(ColorType.Colour.Dark);
            p1 = creator.GetPlayerOne();
            p2 = creator.GetPlayerTwo();
            turn = true;
            removing = false;

        }

        /// <summary>
        /// Sets a node at a given index to a Cow and then checks for a valid mill
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool PlaceCow (int index)
        {
            CurrentBoard.SetNode(index, TurnCow());
            return (CurrentBoard.CheckIndexForMill(index, Turn(turn)));
        }
        /// <summary>
        /// Move takes in a index of an ellipse and then uses the game state variables it has within it to call various methods to facilitate appropriate actions.
        /// </summary>
        /// <param name="index"></param>
        public Board Move (int index)
        {
            verifier = new ValidPositionVerifier(CurrentBoard);
            if(command!=null)
            {
                command.Execute();
            }  
            if(removing)
            {
                bool inMill = CurrentBoard.CheckIndexForMill(index, Turn(!turn));
                bool allInMill = !CurrentBoard.ContainsCowNotinMill(Turn(!turn));
                bool ownedByOpponent = verifier.VerifyOwnByPlayer(index, Turn(!turn));
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
                switch (Turn(turn).GetPhase())
                {
                    case (Phase.Moving):
                        if(verifier.VerifyOwnByPlayer(index, Turn(turn))&& verifier.VerifyAdjacent(CurrentBoard.GetAdjacent(index)))
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
                        if (verifier.VerifyOwnByPlayer(index, Turn(turn)))
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

        public Player Turn(bool turn)
        {
            return turn? p1 : p2;
        }
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
        public void NextTurn()
        {
            turn = !turn;
        }
        public void SetTurnPhase(Phase phase)
        {
            if (turn) p1.SetPhase(phase);
            else p2.SetPhase(phase);
        }
        public Cow TurnCow()
        {
            return turn ? p1.GetCow() : p2.GetCow();
        }
        public List<string> InfoToString()
        {
            List<string> info = new List<string>();
            info.Add(turn ? "Player One" : "Player Two");
            info.Add(Turn(turn).GetPhase().ToString());
            info.Add(instructions());


            return info;
        }
        public string instructions()
        {
            string inst="";
            if (removing) inst= "Choose A valid Position Containing one of your opponents cows to kill";
            else
            {
                switch(Turn(turn).GetPhase())
                {
                    case (Phase.Moving):
                        inst = "Choose a valid cow to move";
                        break;
                    case (Phase.Moving2):
                        inst = "Choose where to move your cow";
                        break;
                    case (Phase.Placing):
                        inst = "Choose one of your " + Turn(turn).GetUnplaced() + " remaining pieces to place";
                        break;
                    case (Phase.Flying):
                        inst = "Choose a valid cow to fly to a new position";
                        break;
                    case (Phase.Flying2):
                        inst = "Choose where to Fly your chosen cow";
                        break;

                }

            }


            return inst;
        }
        /// <summary>
        /// Returns true if one of the players has met the losing condition
        /// </summary>
        /// <returns>boolean</returns>
      public bool GetPlayerLostOrNot()
      {
            return turn ? p1.GetHasLost() : p2.GetHasLost();
      }
        /// <summary>
        /// returns the cow list that makes up board
        /// </summary>
        /// <returns>List<Cow></returns>
      public List<Cow> GetBoard()
        {
            return CurrentBoard.GetNodes();
        }
      public bool getTurn()
        {
            return turn;
        }
    }
}
