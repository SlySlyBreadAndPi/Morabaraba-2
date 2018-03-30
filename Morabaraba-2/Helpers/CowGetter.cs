using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using Morabaraba_2.Models;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for getting an Ellipse
    /// From a Grids Children Collection
    /// </summary>
    public class CowGetter
    {
        UIElementCollection elementCollection;
        private List<Cow> nodes;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="collection">Grids Children collection</param>
        public CowGetter(UIElementCollection collection)
        {
            elementCollection = collection;
        }

        /// <summary>
        /// Returns an Ellipse at the specified position
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Ellipse GetEllipse(int index)
        {
            if(index < 0)
            {
                return new Ellipse();
            }
            return elementCollection[index]as Ellipse;
        }
        /// <summary>
        /// Returns a cow at the specified positon
        /// fails if the given index is invalid
        /// </summary>
        /// <param name="index"></param>
        /// <returns> a cow </returns>
        public Cow GetCow(int index)
        {
            if(index < 0)
            {
                return new Cow();
            }
            return nodes[index];
        } 
    }
}
