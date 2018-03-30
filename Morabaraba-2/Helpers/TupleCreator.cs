using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for creating Tuples of 
    /// any arity
    /// </summary>
   public class TupleCreator
   {
        /// <summary>
        /// Constructor
        /// </summary>
        public TupleCreator()
        {
           
        }
        /// <summary>
        /// Responsible for creating a Tuple that consists of a Turn dataType as well as a bool
        /// value
        /// </summary>
        /// <param name="turn"> Indicates whos turn it currently is</param>
        /// <param name="value">Boolean value indicating if a mill was found or not</param>
        /// <returns></returns>
        public Tuple<WhosTurn.Turn, bool> CreatTurnByBoolTuple(WhosTurn.Turn turn,bool value)
        {
            return new Tuple<WhosTurn.Turn, bool>(turn, value);
        }
        /// <summary>
        /// Responsible for creating a Tuple Consisting of Turn,Bool,Board and Player
        /// </summary>
        /// <param name="turn">Next players turn</param>
        /// <param name="value">If a mill was found or not</param>
        /// <param name="board">Updated state of the board</param>
        /// <param name="player">Updated Player object</param>
        /// <returns>Tuple<WhosTurn.Turn, bool,Board,Player></returns>
        public Tuple<WhosTurn.Turn, bool, Board, Player> CreateTurnByBoolByPlayerTuple(WhosTurn.Turn turn,bool value,Board board,Player player)
        {
            return new Tuple<WhosTurn.Turn, bool, Board, Player>(turn,value,board, player);
        }
        /// <summary>
        /// Responsible for creating a Tuple Consisting of Bool,Board,Player
        /// </summary>
        /// <param name="value">Whether or not a mill was found</param>
        /// <param name="board">Updated state of the board</param>
        /// <param name="player">Updated Player object</param>
        /// <returns>Tuple<WhosTurn.Turn, bool,Board,Player></returns>
        public Tuple<Player, Board, bool> CreateBoolByBoardByPlayerTuple(Player player,Board board, bool value)
        {
            return new Tuple<Player, Board, bool>(player, board, value);
        }
        /// <summary>
        /// Creates a int by int by int tupple
        /// </summary>
        /// <param name="item1">Item 1</param>
        /// <param name="item2">Item 2</param>
        /// <param name="item3">Item 3</param>
        /// <returns>new Tupple</returns>
        public Tuple<int,int,int> CreateIntByIntByIntTupple(int item1,int item2,int item3)
        {
            return new Tuple<int, int, int>(item1, item2, item3);
        }
    }
}
