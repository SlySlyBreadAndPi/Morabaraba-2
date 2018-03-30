using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
using static Morabaraba_2.Models.ColorType;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for Changing an Ellipse Background After Each Turn
    /// </summary>
    public class EllipseColorChanger
    {
        EllipseColorConverter converter;

        /// <summary>
        /// Constructor
        /// </summary>
        public EllipseColorChanger()
        {
            converter = new EllipseColorConverter();
        }
        /// <summary>
        /// Changes an Ellipse to an actual color
        /// </summary>
        /// <param name="cow">Ellipse whos color is to be changed</param>
        /// <param name="color">The color that it should be changed to</param>
        public void ChangeColor(ref Ellipse cow, Models.ColorType.Color color)
        {
            cow.Fill = converter.GetActualEllipseColor(color);
        }
        /// <summary>
        /// Changes an Ellipse to an actual color
        /// </summary>
        /// <param name="cow">Ellipse whos color is to be changed</param>
        /// <param name="color">The color that it should be changed to</param>
        /// <returns>new Ellipse with its Fill Value changed accorgind to the specified color</returns>
        public Ellipse changeColor(Ellipse cow,ColorType.Color color)
        {
            cow.Fill = converter.GetActualEllipseColor(color);
            return cow;
        }
        /// <summary>
        /// Changes the Color of the Nodes on the Board Highlight the opponents cows only
        /// </summary>
        /// <param name="piecesParent"> Actual cows on the board i.e. Ellipse shape</param>
        /// <param name="tempBoard">Board</param>
        public void ChangeColor(ref Grid piecesParent, Board tempBoard)
        {
            EllipseColorConverter converter = new EllipseColorConverter();
            EllipseNameToIndexConverter nameToIndexConverter = new EllipseNameToIndexConverter();
            EllipseNameToIndexConverter converter1 = new EllipseNameToIndexConverter();
            OnBoardCowGetter cowGetter = new OnBoardCowGetter(piecesParent.Children,tempBoard.Nodes);
            for (int i =0; i < piecesParent.Children.Count; i++)
            {
                var cow = tempBoard.Nodes[i];
                var ellipse = (piecesParent.Children[i] as Ellipse);//doing this so we have an Ellipse to work with
                int actualIndex = cowGetter.GetCow(ellipse.Name);
                ellipse=(piecesParent.Children[actualIndex] as Ellipse);//re assingn it
                //ellipse = (piecesParent.Children[nameToIndexConverter.ConvertNameToIndex(ellipse.Name)] as Ellipse);
                ellipse.Fill = converter.GetActualEllipseColor(cow.CowType);
            }
        }
        /// <summary>
        /// Changes a Cow (Game version of what a cow is) to an actual color
        /// </summary>
        /// <param name="cow">Ellipse whos color is to be changed</param>
        /// <param name="color">The color that it should be changed to</param>
        /// <returns>new Ellipse with its Fill Value changed accorgind to the specified color</returns>
        public void ChangeColor(ref Cow cow,ColorType.Color color)
        {
            cow.CowType = color;
        }
    }
}
