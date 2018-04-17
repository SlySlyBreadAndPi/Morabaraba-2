using System.Linq;
using Morabaraba_2.Models;
using Morabaraba_2.Classes;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for Changing an Ellipse Background After Each Turn
    /// </summary>
    public class EllipseColorChanger : IEllipseColorChanger
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
        public void ChangeColor(ref Cow cow, Models.ColorType.Colour color)
        {
            cow.Set(color);
        }
        /// <summary>
        /// Changes an Ellipse to an actual color
        /// </summary>
        /// <param name="cow">Ellipse whos color is to be changed</param>
        /// <param name="color">The color that it should be changed to</param>
        /// <returns>new Ellipse with its Fill Value changed accorgind to the specified color</returns>
        public Cow changeColor(Cow cow, ColorType.Colour color)
        {
            cow.Set(color);
            return cow;
        }
        /// <summary>
        /// Changes the Color of the Nodes on the Board Highlight the opponents cows only
        /// </summary>
        /// <param name="piecesParent"> Actual cows on the board i.e. Ellipse shape</param>
        /// <param name="tempBoard">Board</param>
     /*   public void ChangeColor(ref Grid piecesParent, Board tempBoard)
        {
            EllipseColorConverter converter = new EllipseColorConverter();
            EllipseConverter nameToIndexConverter = new EllipseConverter();
            for (int i = 0; i < piecesParent.Children.Count; i++)
            {
                var cow = tempBoard.GetNode(i);
                var ellipse = (piecesParent.Children[i] as Ellipse);//doing this so we have an Ellipse to work with
                ellipse = (piecesParent.Children[i] as Ellipse);//re assingn it
                //ellipse = (piecesParent.Children[nameToIndexConverter.ConvertNameToIndex(ellipse.Name)] as Ellipse);
                ellipse.Fill = converter.GetActualEllipseColor(cow.Get());
            }
        }
        */
        /// <summary>
        /// Changes a Cow (Game version of what a cow is) to an actual color
        /// </summary>
        /// <param name="cow">Ellipse whos color is to be changed</param>
        /// <param name="color">The color that it should be changed to</param>
        /// <returns>new Ellipse with its Fill Value changed accorgind to the specified color</returns>
      
    }
}