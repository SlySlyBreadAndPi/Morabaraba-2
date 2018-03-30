using Morabaraba_2.Helpers;
using Morabaraba_2.Helpers;
using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// This class holds the current game session between two players
    /// </summary>

    public class Morabaraba
    {
        Game currentGameState;
        PlayerCreator creator;
        GameBoardInitialisor init;
        MillChecker checker;
        /// <summary>
        /// Constructor
        /// </summary>
        public Morabaraba(SelectedColor color)
        {
            creator = new PlayerCreator(color);
        }
        /// <summary>
        /// Initialises the Current Game Session Objects
        /// </summary>
        /// <param name="parent"></param>
        public void Init(Grid parent)
        {
            init = new GameBoardInitialisor(parent);
            currentGameState = new Game { p1 = creator.CreatePlayerOne(), p2 = creator.CreatePlayerTwo(), CurrentBoard = init.InitializeBoard() };
        }
        /// <summary>
        /// Responsible for Making allowing the player to make a move 
        /// This method is the intermediary between the UI and 
        /// the rest of the game
        /// </summary>
        /// <param name="pos">The cow postion the Player whises to place a cow in</param>
        /// <param name="turn">Next Players turn</param>
        /// <returns></returns>
        public Tuple<WhosTurn.Turn,bool>  Play(Cow pos,WhosTurn.Turn turn)
        {
            TupleCreator creator;
            creator = new TupleCreator();
            var turnMill = creator.CreatTurnByBoolTuple(turn, false);//defualt     
            var play = new Play();
            TupleExtractor Tupleextractor;
            if(turn == WhosTurn.Turn.Player1)
            {
                var newPlayerBoardTurn = play.PlaceCow(pos,currentGameState.CurrentBoard,currentGameState.p1,turn);
                Tupleextractor = new TupleExtractor(newPlayerBoardTurn);
                var newPlayer = Tupleextractor.GetUpdatedPlayerType1Tuple();
                turn = Tupleextractor.GetUpdatedTurnType1Tuple();
                var newBoard = Tupleextractor.GetUpdatedBoardType1Tuple();
                var millFound = Tupleextractor.GetFoundMillValueType1Tuple();
                creator = new TupleCreator();
                turnMill = creator.CreatTurnByBoolTuple(turn, millFound);
                currentGameState.CurrentBoard = newBoard;
                currentGameState.p1 = newPlayer;
            }
            else
            {
                var newPlayerBoardTurn = play.PlaceCow(pos, currentGameState.CurrentBoard, currentGameState.p2,turn);
                Tupleextractor = new TupleExtractor(newPlayerBoardTurn);
                var newPlayer = Tupleextractor.GetUpdatedPlayerType1Tuple();
                turn = Tupleextractor.GetUpdatedTurnType1Tuple();
                var newBoard = Tupleextractor.GetUpdatedBoardType1Tuple();
                var millFound = Tupleextractor.GetFoundMillValueType1Tuple();
                creator = new TupleCreator();
                turnMill = creator.CreatTurnByBoolTuple(turn, millFound);
                currentGameState.CurrentBoard = newBoard;
                currentGameState.p2 = newPlayer;
            }
            return turnMill;
        }
        /// <summary>
        /// Removes an opponents cow from the board
        /// </summary>
        /// <param name="ellipseClicked">Cow that was clicked on and to be removed</param>
        /// <param name="piecesParent">The Actual board i.e. human readable board</param>
        ///<param name="otherPlayer">used for checking if the other player has placed all they cows </param>
        public void RemoveOpponentsPlacedCows(Ellipse ellipseClicked, ref Grid piecesParent,Player otherPlayer)
        {
            EllipseNameToIndexConverter converter = new EllipseNameToIndexConverter();
            OnBoardCowGetter cowGetter = new OnBoardCowGetter(piecesParent.Children, currentGameState.CurrentBoard.Nodes);
            CowRemover remover = new CowRemover(currentGameState.CurrentBoard);
            CowUpdater updater = new CowUpdater(piecesParent);
            var OnBoardIndex = cowGetter.GetCow(ellipseClicked.Name);
            var cow = cowGetter.GetCow(OnBoardIndex);
            if (cow.InAmill &&otherPlayer.Unplaced>0) return;///A cow in a mill may not be shot unless all of the opponent's cows are in mills, in which case any cow may be shot. 
            currentGameState.CurrentBoard = remover.RemoveCow(cow);
            Synchronizer sync = new Synchronizer(currentGameState.CurrentBoard.Nodes, piecesParent);
            //piecesParent =updater.Update(cow);
            piecesParent = sync.Synchronize();

        }

        /// <summary>
        /// Gets the Current state of the Board
        /// </summary>
        /// <returns> Board </returns>
        public Board GetBoard()
        {
          return currentGameState.CurrentBoard;
        }
        /// <summary>
        /// Returns a player 
        /// </summary>
        /// <param name="turn">Used for determining which player to return</param>
        /// <returns></returns>
        public Player GetPlayer(WhosTurn.Turn turn)
        {
          return turn == WhosTurn.Turn.Player1 ? currentGameState.p1 : currentGameState.p2;
        }
    }
}
