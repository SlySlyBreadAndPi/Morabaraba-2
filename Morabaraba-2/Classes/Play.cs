using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Classes
{
    public class Play
    {
        /// <summary>
        /// Soley responsibe for placing a cow on the board
        /// </summary>
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
        public bool PlaceCow(Cow pos,ref Board board)
        {




            return true;

        }
    }
}
