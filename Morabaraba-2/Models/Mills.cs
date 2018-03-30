using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Models
{
    /// <summary>
    /// The Mill Data structure is responsible for keeping track of 
    /// Every index on the Board as well as every mill that
    /// Could be formed from that index
    /// 
    /// </summary>
    public class Mills
    {
        //Keeps track of the current index
        public int IndexOnBoard { get; set; }
        //Keeps track of every possible mill that could be formed from the current index
        public List<Tuple<Cow, Cow, Cow>> AdjacentMills {get;set;}
    }
}
