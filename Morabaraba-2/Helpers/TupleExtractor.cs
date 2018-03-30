using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for Extractin Tuples
    /// </summary>
    public class TupleExtractor
    {
        /// <summary>
        /// Constructor
        /// </summary>
        #region Define different types of tuples between this region
        private Tuple<WhosTurn.Turn, bool, Board, Player> type1;
        private Tuple<Player, bool> type2;
        private Tuple<WhosTurn.Turn, bool> type3;
        private Tuple<Cow, Cow, Cow> type4;
        private IEnumerable<Tuple<int, int, int>> combo;
        #endregion
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="t1"></param>
        public TupleExtractor(Tuple<WhosTurn.Turn, bool, Board, Player> t1)
        {
            type1 = t1;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="t2"></param>
        public TupleExtractor(Tuple<Player, bool> t2)
        {
            type2 = t2;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="t3"></param>
        public TupleExtractor(Tuple<WhosTurn.Turn, bool> t3)
        {
            type3 = t3;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="t4"></param>
        public TupleExtractor(Tuple<Cow,Cow,Cow> t4)
        {
            type4 = t4;
        }

        public TupleExtractor(IEnumerable<Tuple<int, int, int>> combo)
        {
            this.combo = combo;
        }

        /// <summary>
        /// Extracts the Turn from the tuple
        /// </summary>
        /// <returns>Returns a Value indicating whos turn it is next</returns>
        public WhosTurn.Turn GetUpdatedTurnType1Tuple()
        {
            return type1.Item1;
        }
        /// <summary>
        /// Gets the value that indicates whether a mill
        /// was found or not
        /// </summary>
        /// <returns>Returns a boolean value that indicates whether we found a mill or not</returns>
        public bool  GetFoundMillValueType1Tuple()
        {
            return type1.Item2;
        }
        /// <summary>
        /// Extracts the Updated Board from the Tuple
        /// </summary>
        /// <returns> returns the updated Board</returns>
        public Board GetUpdatedBoardType1Tuple()
        {
            return type1.Item3;
        }
        /// <summary>
        /// Extracts the Player Object from the Tuple
        /// </summary>
        /// <returns>The Updated Player</returns>
        public Player GetUpdatedPlayerType1Tuple()
        {
            return type1.Item4;
        }
        /// <summary>
        ///  Returns the Player value from from the type 2 Tuple
        /// </summary>
        /// <returns>Player </returns>
        public Player GetUpdatedPlayerType2Tuple()
        {
            return type2.Item1;
        }
        /// <summary>
        /// Returns the Bool value from from the type 2 Tuple
        /// </summary>
        /// <returns>returns bool</returns>
        public bool GetFoundMillType2Tuple()
        {
            return type2.Item2;
        }
        /// <summary>
        /// Gets whos turn it is next from the type 3 Tuple
        /// </summary>
        /// <returns>Turn</returns>
        public WhosTurn.Turn GetWhosTurnType3Tuple()
        {
            return type3.Item1;
        }
        /// <summary>
        /// Gets the value indicating whether a mill was found
        /// or not from the type 3 Tuple
        /// </summary>
        /// <returns>Boolean</returns>
        public bool GetMillFoundType3Tuple()
        {
            return type3.Item2;
        }
        /// <summary>
        /// returns an item from the type 4 tuple based on the index provided
        /// </summary>
        /// <param name="itemNo"></param>
        /// <returns></returns>
        public Cow GetType4TupleCow(int itemNo)
        {
            Cow temp = new Cow();
            switch (itemNo)
            {
                case 1:
                    temp = type4.Item1;
                    break;
                case 2:
                    temp = type4.Item2;
                    break;
                case 3:
                    temp = type4.Item3;
                    break;
            }
            return temp;
        }
        /// <summary>
        /// returns an item from the combo list based on the index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Tuple<int,int,int> GetComboItems(int index)
        {
            return combo.ToList()[index];

        }
    }
}
