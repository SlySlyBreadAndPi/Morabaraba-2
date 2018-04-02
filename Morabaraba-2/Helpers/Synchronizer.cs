using Morabaraba_2.Models;
using Morabaraba_2.Classes;
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
    /// Responsible for synchronising the Grid which contains the Ellipses
    /// With latest version of the Non human readable version of the Board
    /// </summary>
   public class Synchronizer
   {
        Grid HumanReadableBoard;
        /// <summary>
        /// Constrcutor
        /// </summary>
        /// <param name="cows"></param>
        public Synchronizer(Grid humanReadableBoard)
        {
            HumanReadableBoard = humanReadableBoard;
        }
        public Grid Synchronize(Board cows)
        {
            EllipseColorConverter converter = new EllipseColorConverter();
            //EllipseIndexToNameConverter ellipseIndexToNameConverter = new EllipseIndexToNameConverter();
            //EllipseNameToIndexConverter ellipseNameToIndexConverter = new EllipseNameToIndexConverter();
            for(int i =0; i < cows.GetNodes().Count; i++)
            {
                EllipseColorChanger changer = new EllipseColorChanger();
                Ellipse current = HumanReadableBoard.Children[i] as Ellipse;
                Cow currentCow = cows.GetNode(i);
                HumanReadableBoard.Children[i] = changer.changeColor(current, currentCow.Get());
                HumanReadableBoard.Children[i].IsEnabled = true;
            }
            return HumanReadableBoard;
        }
   }
}
