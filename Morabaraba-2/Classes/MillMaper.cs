using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Classes
{
    /// <summary>
    /// MillMapper Class is respondible for generating every possible mill in the Game
    /// </summary>
   public class MillMaper
   {
        //Keeps track of every possible mill in the game
        List<Mill> PossibleMills;
        public MillMaper()
        {
            GenerateMills();
        }
        /// <summary>
        /// Generates Every possible mill that could be formed in the Game
        /// </summary>
        public void GenerateMills()
        {
            PossibleMills = new List<Mill>();
            ColorType.Color temp = ColorType.Color.Empty;
            List<Tuple<Cow, Cow, Cow>> Adjacent = new List<Tuple<Cow, Cow, Cow>>();
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 1 }, new Cow { CowType = temp, IndexonBoard = 2 }, new Cow { CowType = temp, IndexonBoard = 0 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 3 }, new Cow { CowType = temp, IndexonBoard = 6 }, new Cow { CowType = temp, IndexonBoard = 0 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 9 }, new Cow { CowType = temp, IndexonBoard = 21 }, new Cow { CowType = temp, IndexonBoard = 0 }));
            PossibleMills.Add(new Mill { IndexOnBoard=0,AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 1 }, new Cow { CowType = temp, IndexonBoard = 2 }, new Cow { CowType = temp, IndexonBoard = 0 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 4 }, new Cow { CowType = temp, IndexonBoard = 7 }, new Cow { CowType = temp, IndexonBoard = 1 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 1, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 1 }, new Cow { CowType = temp, IndexonBoard = 2 }, new Cow { CowType = temp, IndexonBoard = 0 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 5 }, new Cow { CowType = temp, IndexonBoard = 8 }, new Cow { CowType = temp, IndexonBoard = 2 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 14 }, new Cow { CowType = temp, IndexonBoard = 23 }, new Cow { CowType = temp, IndexonBoard = 2 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 2, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 0 }, new Cow { CowType = temp, IndexonBoard = 6 }, new Cow { CowType = temp, IndexonBoard = 3 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 3 }, new Cow { CowType = temp, IndexonBoard = 5 }, new Cow { CowType = temp, IndexonBoard = 4 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 18 }, new Cow { CowType = temp, IndexonBoard = 10 }, new Cow { CowType = temp, IndexonBoard = 3 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 3, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 1 }, new Cow { CowType = temp, IndexonBoard = 7 }, new Cow { CowType = temp, IndexonBoard = 4 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 3 }, new Cow { CowType = temp, IndexonBoard = 5 }, new Cow { CowType = temp, IndexonBoard = 4 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 4, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 2 }, new Cow { CowType = temp, IndexonBoard = 8 }, new Cow { CowType = temp, IndexonBoard = 5 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 4 }, new Cow { CowType = temp, IndexonBoard = 3 }, new Cow { CowType = temp, IndexonBoard = 5 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 13 }, new Cow { CowType = temp, IndexonBoard = 20 }, new Cow { CowType = temp, IndexonBoard = 5 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 5, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 7 }, new Cow { CowType = temp, IndexonBoard = 8 }, new Cow { CowType = temp, IndexonBoard = 6 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 6 }, new Cow { CowType = temp, IndexonBoard = 0 }, new Cow { CowType = temp, IndexonBoard = 3 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 11 }, new Cow { CowType = temp, IndexonBoard = 15 }, new Cow { CowType = temp, IndexonBoard = 6 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 6, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 6 }, new Cow { CowType = temp, IndexonBoard = 8 }, new Cow { CowType = temp, IndexonBoard = 7 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 4 }, new Cow { CowType = temp, IndexonBoard = 1 }, new Cow { CowType = temp, IndexonBoard = 7 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 7, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 12 }, new Cow { CowType = temp, IndexonBoard = 17 }, new Cow { CowType = temp, IndexonBoard = 8 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 5 }, new Cow { CowType = temp, IndexonBoard = 2 }, new Cow { CowType = temp, IndexonBoard = 8 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 6 }, new Cow { CowType = temp, IndexonBoard = 7 }, new Cow { CowType = temp, IndexonBoard = 8 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 8, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 10 }, new Cow { CowType = temp, IndexonBoard = 11 }, new Cow { CowType = temp, IndexonBoard = 9 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 0 }, new Cow { CowType = temp, IndexonBoard = 21 }, new Cow { CowType = temp, IndexonBoard = 9 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 9, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 11 }, new Cow { CowType = temp, IndexonBoard = 9 }, new Cow { CowType = temp, IndexonBoard = 10 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 3 }, new Cow { CowType = temp, IndexonBoard = 18 }, new Cow { CowType = temp, IndexonBoard = 10 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 10, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 9 }, new Cow { CowType = temp, IndexonBoard = 10 }, new Cow { CowType = temp, IndexonBoard = 11 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 3 }, new Cow { CowType = temp, IndexonBoard = 15 }, new Cow { CowType = temp, IndexonBoard = 11 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 11, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 8 }, new Cow { CowType = temp, IndexonBoard = 17 }, new Cow { CowType = temp, IndexonBoard = 12 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 13 }, new Cow { CowType = temp, IndexonBoard = 14 }, new Cow { CowType = temp, IndexonBoard = 12 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 12, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 12 }, new Cow { CowType = temp, IndexonBoard = 14 }, new Cow { CowType = temp, IndexonBoard = 13 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 5 }, new Cow { CowType = temp, IndexonBoard = 20 }, new Cow { CowType = temp, IndexonBoard = 13 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 13, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 12 }, new Cow { CowType = temp, IndexonBoard = 13 }, new Cow { CowType = temp, IndexonBoard = 14 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 2 }, new Cow { CowType = temp, IndexonBoard = 23 }, new Cow { CowType = temp, IndexonBoard = 14 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 14, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 17 }, new Cow { CowType = temp, IndexonBoard = 16 }, new Cow { CowType = temp, IndexonBoard = 15 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 11 }, new Cow { CowType = temp, IndexonBoard = 6 }, new Cow { CowType = temp, IndexonBoard = 15 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 18 }, new Cow { CowType = temp, IndexonBoard = 21 }, new Cow { CowType = temp, IndexonBoard = 15 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 15, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 15 }, new Cow { CowType = temp, IndexonBoard = 17 }, new Cow { CowType = temp, IndexonBoard = 16 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 19 }, new Cow { CowType = temp, IndexonBoard = 22 }, new Cow { CowType = temp, IndexonBoard = 16 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 16, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 15 }, new Cow { CowType = temp, IndexonBoard = 16 }, new Cow { CowType = temp, IndexonBoard = 17 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 12 }, new Cow { CowType = temp, IndexonBoard = 8 }, new Cow { CowType = temp, IndexonBoard = 17 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 20 }, new Cow { CowType = temp, IndexonBoard = 23 }, new Cow { CowType = temp, IndexonBoard = 17 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 17, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 19 }, new Cow { CowType = temp, IndexonBoard = 20 }, new Cow { CowType = temp, IndexonBoard = 18 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 10 }, new Cow { CowType = temp, IndexonBoard = 3 }, new Cow { CowType = temp, IndexonBoard = 18 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 21 }, new Cow { CowType = temp, IndexonBoard = 15 }, new Cow { CowType = temp, IndexonBoard = 18 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 18, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 18 }, new Cow { CowType = temp, IndexonBoard = 20 }, new Cow { CowType = temp, IndexonBoard = 19 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 16 }, new Cow { CowType = temp, IndexonBoard = 22 }, new Cow { CowType = temp, IndexonBoard = 19 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 19, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 19 }, new Cow { CowType = temp, IndexonBoard = 18 }, new Cow { CowType = temp, IndexonBoard = 20 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 23 }, new Cow { CowType = temp, IndexonBoard = 17 }, new Cow { CowType = temp, IndexonBoard = 20 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 13 }, new Cow { CowType = temp, IndexonBoard = 5 }, new Cow { CowType = temp, IndexonBoard = 20 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 20, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 22 }, new Cow { CowType = temp, IndexonBoard = 23 }, new Cow { CowType = temp, IndexonBoard = 21 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 9 }, new Cow { CowType = temp, IndexonBoard = 0 }, new Cow { CowType = temp, IndexonBoard = 21 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 18 }, new Cow { CowType = temp, IndexonBoard = 15 }, new Cow { CowType = temp, IndexonBoard = 12 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 21, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 21 }, new Cow { CowType = temp, IndexonBoard = 23}, new Cow { CowType = temp, IndexonBoard = 22 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 19 }, new Cow { CowType = temp, IndexonBoard = 16 }, new Cow { CowType = temp, IndexonBoard = 22 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 22, AdjacentMills = Adjacent });
            Adjacent.Clear();

            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 21 }, new Cow { CowType = temp, IndexonBoard = 22 }, new Cow { CowType = temp, IndexonBoard = 23 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 20 }, new Cow { CowType = temp, IndexonBoard = 17 }, new Cow { CowType = temp, IndexonBoard = 23 }));
            Adjacent.Add(new Tuple<Cow, Cow, Cow>(new Cow { CowType = temp, IndexonBoard = 14 }, new Cow { CowType = temp, IndexonBoard = 2 }, new Cow { CowType = temp, IndexonBoard = 23 }));
            PossibleMills.Add(new Mill { IndexOnBoard = 23, AdjacentMills = Adjacent });
            Adjacent.Clear();
        }
        /// <summary>
        /// Returns the Gnerated Mills
        /// </summary>
        /// <returns></returns>
        public List<Mill> GetAdjacentMills()
        {
            return PossibleMills;
        }
        public List<Tuple<Cow,Cow,Cow>> GetMillByIndex(int index)
        {
            if (index > PossibleMills.Count && index < 0) return new List<Tuple<Cow, Cow, Cow>>();
            return PossibleMills.ElementAt(index).AdjacentMills;
        }
    }
}
