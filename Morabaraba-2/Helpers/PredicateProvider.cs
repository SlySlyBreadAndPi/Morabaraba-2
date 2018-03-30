using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
    public class PredicateProvider
    {
        /// <summary>
        /// Responsible for providing small methods i.e. Predicates that can be used in List Functions
        /// </summary>
        ///
        Predicate<int> Type1;
        public PredicateProvider()
        {
            Type1 = EqualsMinusOne;
        }
        /// <summary>
        /// Method checks if an item is equal to -1 or not
        /// </summary>
        /// <param name="item">Number to be checked</param>
        /// <returns></returns>
        public bool EqualsMinusOne(int item)
        {
            return item == -1 ? true : false;
        }
        /// <summary>
        /// Retruns the type 1 predicate for checking if an item is equal to -1
        /// </summary>
        /// <returns>  Predicate<int></returns>
        public Predicate<int> GetPredicate()
        {
            return Type1;
        }
 
    }
}
