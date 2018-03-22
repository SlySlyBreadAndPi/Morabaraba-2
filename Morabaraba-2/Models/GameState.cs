using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Models
{
   public class GameState
    {
        /// <summary>
        /// This is a simple object to judge whether or not the game-state is currently in play or over. We may decide to take this state out later
        /// </summary>
        public enum State
       {
           Playing,
           Gameover

       }
    }
}
