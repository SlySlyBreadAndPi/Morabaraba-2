using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorabarabaNS.Models
{
    /// <summary>
    /// The color object is used by cows to determine their state. 
    /// It is the primary feature of the cow object
    /// There are 3 states because the cow (which represents a position on the board) is either owned by a player or is empty
    /// </summary>
    public static class ColorType
    {
        public enum Colour
        {
            Dark,
            Light,
            Empty
        };
    }
}
