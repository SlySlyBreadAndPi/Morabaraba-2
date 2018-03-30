using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
    public class Play
    {
        MakeMove movemaker;
        /// <summary>
        /// Soley responsibe for placing a cow on the board
        /// </summary>
        public Play()
        {
            movemaker = new MakeMove();
        }
        /// <summary>
        /// Responsible for Placing a cow on the board
        /// We abstracted this to its own class becuase we didnt want to be DRY XD 
        /// basically we wanted to follow the DRY principle of not repeating your self 
        /// ignore the above i just thought it would be cool to have a seperate class for this
        /// </summary>
        /// <param name="pos">Cow to be placed on the board</param>
        /// <param name="board">Current board state</param>
        /// <param name="player">Current Player turn</param>
        /// <param name="checker">Used to keep track of already used mills</param>
        /// <returns></returns>
        public Tuple<WhosTurn.Turn, bool, Board, Player> PlaceCow(Cow pos,Board board,Player player,WhosTurn.Turn turn)
        {
            TupleCreator tupleCreator = new TupleCreator();
            var updatedPlayerBoard = movemaker.Move(player, board, pos);
            var newPlayer = updatedPlayerBoard.Item1;//get the updatedPlayer from the tuple
            var newBoard = updatedPlayerBoard.Item2;//Get the board from the tupple
            var foundMill = updatedPlayerBoard.Item3;//indicates whether or not a mill was found or not 
            turn = turn==WhosTurn.Turn.Player1?WhosTurn.Turn.Player2:WhosTurn.Turn.Player1;
           return tupleCreator.CreateTurnByBoolByPlayerTuple(turn, foundMill,newBoard,newPlayer);
        }
    }
}
