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
    /// Responsible for reseting the color of 
    /// every Ellipse in List to white
    /// </summary>
    public class ListReinitializer
    {


        List<object> Items;
        private UIElementCollection tempEllipeses;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="items">Items to be reset</param>
        public ListReinitializer(List<object> items)
        {
            Items = items;
        }

        public ListReinitializer(UIElementCollection tempEllipeses)
        {
            this.tempEllipeses = tempEllipeses;
        }

        /// <summary>
        ///Converts the List of Objects 
        ///To Ellipse then resets their Color to White
        /// </summary>
        /// <returns>New Collection</returns>
        public List<Ellipse> ResetCollection()
        {
            var tempList = new List<Ellipse>();
            var changer = new EllipseColorChanger();
            for (int i = 0;i < tempEllipeses.Count; i++)
            {
                var ellipse = (tempEllipeses[i] as Ellipse);
                changer.ChangeColor(ref ellipse, ColorType.Color.Empty);
                tempList.Add(ellipse);
            }
                return tempList;
        }
    }

}
