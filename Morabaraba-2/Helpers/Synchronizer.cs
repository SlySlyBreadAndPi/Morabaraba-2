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
    /// Responsible for synchronising the Grid which contains the Ellipses
    /// With latest version of the Non human readable version of the Board
    /// </summary>
   public class Synchronizer
   {
        List<Cow> cows;
        Grid HumanReadableBoard;
        /// <summary>
        /// Constrcutor
        /// </summary>
        /// <param name="cows"></param>
        public Synchronizer(List<Cow> cows,Grid humanReadableBoard)
        {
            this.cows = cows;
            HumanReadableBoard = humanReadableBoard;
        }
        public Grid Synchronize()
        {
            EllipseColorChanger changer = new EllipseColorChanger();
            EllipseIndexToNameConverter ellipseIndexToNameConverter = new EllipseIndexToNameConverter();
            EllipseNameToIndexConverter ellipseNameToIndexConverter = new EllipseNameToIndexConverter();
            OnBoardCowGetter cowGetter = new OnBoardCowGetter(HumanReadableBoard.Children, cows);
            for(int i =0; i < cows.Count; i++)
            {
                Ellipse current = HumanReadableBoard.Children[i] as Ellipse;
                int actualIndex = cowGetter.GetCow(current.Name);
                Cow currentCow = cows[actualIndex];
                HumanReadableBoard.Children[actualIndex] = changer.changeColor(current, currentCow.CowType);
            }
            return HumanReadableBoard;
        }
   }
}
