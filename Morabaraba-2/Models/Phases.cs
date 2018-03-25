using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Models
{
   public  static class Phases
    {
        /// <summary>
        /// This is a value stored within the player class that shows what phase of the game a certain player is in.
        /// It can't apply to both players because each player will be in a different phase at different times.
        /// </summary>
        public enum Phase
        {
            Moving,
            Placing,
            Flying,
            Stationary
        }

    }
}
