using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for getting a cow on the board given an index
    /// Reason for this class the indexes on the Board cannot not be acecssed 
    /// in the conventional way 
    /// Each cow has an associated index 
    /// Which does not correpsond to its actual Index on/in the List
    /// </summary>
    public class OnBoardCowGetter
    {
        List<Cow> Cows;
        private UIElementCollection children;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="cows">Cows on the board</param>
        public OnBoardCowGetter(List<Cow> cows)
        {
            Cows = cows;
        }

        public OnBoardCowGetter(UIElementCollection children,List<Cow> cows)
        {
            this.children = children;
            Cows = cows;
        }

        /// <summary>
        /// Returns a cow 
        /// Based on it actual index on the board
        /// returns null cow if the cow passed in is null
        /// </summary>
        /// <param name="cow">Cow to be fetched</param>
        /// <returns></returns>
        public Cow GetCow(Cow cow)
        {
            if (cow == null) return cow;
            var tempCow = new Cow();
            for(int i = 0; i < Cows.Count; i++)
            {
                if (Cows[i].IndexonBoard == cow.IndexonBoard)
                {
                    tempCow = Cows[i];
                    break;
                }
            }
            return tempCow;
        }
        /// <summary>
        /// Returns a cows index that corresponds to the 
        /// Given name on the board
        /// returns -1 if the name is null or empty
        /// </summary>
        /// <param name="name">Name of the Ellipse that represnts the cows postion on the board</param>
        /// <returns></returns>
        public int GetCow(string name)
        {
            if (String.IsNullOrEmpty(name)) return -1;
            var tempCow = -1;
            for(int i = 0; i < children.Count; i++)
            {
                var ellipse = (children[i] as Ellipse);
                if (name == ellipse.Name)
                {
                    tempCow = i;
                    break;
                }
            }

            return tempCow;
        }
        /// <summary>
        /// Returns a cow based on the given index
        /// returns null cow if the Index passed in is invalid
        /// i.e. less than 0
        /// </summary>
        /// <param name="index"> index of the cow on the board</param>
        /// <returns>cow</returns>
        public Cow GetCow(int index)
        {
            if (index < 0) return new Cow();
            return Cows[index];
        }
    }
}
