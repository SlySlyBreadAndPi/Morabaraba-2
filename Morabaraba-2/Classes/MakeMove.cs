using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
    public class MakeMove
    {
        public MakeMove()
        {
        }
        /// <summary>
        /// Places a cow on the board
        /// returns the updated player as well as the board
        /// </summary>
        /// <param name="player">current player whos turn it is</param>
        /// <param name="board">the current state of the board</param>
        /// <param name="pos"> postion on the board</param>
        ///<param name="check"> Used to keep track of already used mills</param>

        /// <returns></returns>
        public Tuple<Player,Board,bool> Move(Player player,Board board,Cow pos)
        {
            // this is the defualt case if we couldnt make a move we simply return the board and player as is and no millwas found
            //indicated by the false
            Tuple<Player, Board,bool> updatedPlayerBoard=new Tuple<Player, Board,bool>(player,board,false);
            TupleCreator tupleCreator = new TupleCreator();
            MillChecker check = new MillChecker();
            for (int i =0; i < board.Nodes.Count;i++)
            {
                if(board.Nodes[i].CowType ==ColorType.Color.Empty && pos.IndexonBoard == board.Nodes[i].IndexonBoard)
                {
                   player.Unplaced -= 1;//decrement cows on hand
                   player.placed += 1;//increment placed cows
                   board.Nodes[i] = pos;
                   var updatedPlayer= check.CheckForMills(ref board, player);//check if the player has formed any mills
                   var tupleExtractor = new TupleExtractor(updatedPlayer);
                   updatedPlayerBoard=tupleCreator.CreateBoolByBoardByPlayerTuple(updatedPlayer.Item1, board,updatedPlayer.Item2);
                   break;//break out of the loop we only do this once
                } 
            }
            return updatedPlayerBoard;
        }

    }
}
