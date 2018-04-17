using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorabarabaNS.Classes
{
    /// <summary>
    /// Represnts a Mill 
    /// Postion one represents the first postion of the mill
    /// Postion two same as above but second postion
    /// Position three same as above but three
    /// </summary>
    public class Mill : IMill
    {
        private int Position1;
        private int Position2;
        private int Position3;
        
        public Mill(int a,int b,int c)// mill constructor
        {
            Position1 = a;
            Position2 = b;
            Position3 = c;
        }

        public bool ContainsIndex(int index)// checks if a mill contains a specified index
        {
            return Position3 == index || Position2 == index || Position1 == index;
        }

        public List<int> ToList()// returns the mill and all its variables as a list
        {
            return new List<int> { Position1, Position2, Position3 };
        }
    }
}
