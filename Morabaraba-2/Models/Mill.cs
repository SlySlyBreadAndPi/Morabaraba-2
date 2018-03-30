using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Models
{
    /// <summary>
    /// Represnts a Mill 
    /// Postion one represents the first postion of the mill
    /// Postion two same as above but second postion
    /// Position three same as above but three
    /// </summary>
    public class Mill
    {
        public Cow Position1 { get; set; }
        public Cow Position2 { get; set; }

        public Cow Position3 { get; set; }
    }
}
