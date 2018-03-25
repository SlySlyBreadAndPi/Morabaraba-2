using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Classes
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
        /// <returns></returns>
        public Tuple<Player,Board> Move(Player player,Board board,Cow pos)
        {
            Tuple<Player, Board> updatedPlayerBoard=new Tuple<Player, Board>(player,board);// this is the defualt case if we couldnt make a move we simply return the board and player as is
            MillChecker check = new MillChecker();
            for(int i =0; i < board.Nodes.Count;i++)
            {
                if(board.Nodes[i].CowType == pos.CowType && pos.IndexonBoard == board.Nodes[i].IndexonBoard)
                {
                    player.placed -= 1;//decrement cows on hand
                   board.Nodes[i] = pos;
                   var updatedPlayer= check.CheckForMills(board, player);//check if the player has formed any mills
                   updatedPlayerBoard=new Tuple<Player, Board>(updatedPlayer, board);
                   break;//break out of the loop we only do this once
                } 
            }
            return updatedPlayerBoard;
        }

    }
}
