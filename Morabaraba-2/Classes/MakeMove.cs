using Morabaraba_2.Helpers;
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
        ///<param name="check"> Used to keep track of already used mills</param>

        /// <returns></returns>
        public bool Move(Player player,ref Board board,Cow pos)
        {
            // this is the defualt case if we couldnt make a move we simply return the board and player as is and no millwas found
            //indicated by the false

            
          
        }

    }
}
