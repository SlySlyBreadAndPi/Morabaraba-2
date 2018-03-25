using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Morabaraba_2.Models.ColorType;

namespace Morabaraba_2.Models
{
   public  class Cow
    {
        /// <summary>
        /// The cow object represents a position on the board by its position within the board's list of cows. 
        /// It holds a color object because that will show whether it is empty or what player controls it.
        /// IndexonBoard represents the index of the Cow on the Board
        /// </summary>
        public Color CowType { get; set; } 
        public int IndexonBoard { get; set; }
      
    }
}
