using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorabarabaNS.Classes
{
    /// <summary>
    /// The Mill Data structure is responsible for keeping track of 
    /// Every index on the Board as well as every mill that
    /// Could be formed from that index
    /// 
    /// </summary>
    public class Mills : IMills
    {
        //Keeps track of every possible mill that could be formed from the current index
        private List<IMill> mills {get;set;}

        public Mills(List<IMill> mills)// Mills constructor for non empty list
        {
            this.mills = mills ?? throw new ArgumentNullException(nameof(mills));
        }
        public Mills()// mill constructor for empty list
        {
            mills = new List<IMill> { };
        }

        public bool ContainsIndex(int index)// returns true if there is a mill in Mills that contains the value index
        {
            foreach(IMill element in mills)
            {
                if (element.ContainsIndex(index)) return true;
            }
            return false;
        }
        
        public List<IMill> GetMills()//returns all of Mills
        {
            return mills;
        }

        public void Add(IMill mill)//adds a mill to mills
        {
            mills.Add(mill);
        }
        

    }
}
