using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MorabarabaNS.Models.ColorType;

namespace MorabarabaNS.Classes
{
   public  class Cow : ICow
    {
        /// <summary>
        /// The cow object represents a position on the board by its position within the board's list of cows. 
        /// It holds a color object because that will show whether it is empty or what player controls it.
        /// IndexonBoard represents the index of the Cow on the Board
        /// InAMill indicates whether the Current cow is in a mill or not
        /// </summary>
        private Colour CowType;


        public Cow(Colour c)// cow construnctor
        {
            CowType = c;
        }
        public Colour Get() // returns Cowtype
        {
            return CowType;
        }
        public void Set(Colour c)// sets cowType
        {
            CowType = c;
        }
      
    }
}
