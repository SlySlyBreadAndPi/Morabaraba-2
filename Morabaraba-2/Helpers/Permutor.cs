using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
   public class Permutor
   {
        IEnumerable<IEnumerable<int>> Positions;
        public Permutor(IEnumerable<int> local)
        {
           Positions= GetPermutations(local, 3);
        }

        private IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (count == 1)
                    yield return new T[] { item };
                else
                {
                    foreach (var result in GetPermutations(items.Skip(i + 1), count - 1))
                        yield return new T[] { item }.Concat(result);
                }

                ++i;
            }
        }
        public IEnumerable<IEnumerable<T>> GetPermutations<T>()
        {
            return Positions as IEnumerable<IEnumerable<T>>;
        }
    }
}
