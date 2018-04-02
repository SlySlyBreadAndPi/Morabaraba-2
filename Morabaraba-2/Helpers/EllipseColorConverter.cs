using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Morabaraba_2.Properties;
namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for coonverting the Actual ellipse color to the Games representation color
    /// For Instance the Colour White on the Ellipse represents Nothing 
    /// Black represents Dark
    /// Yellow represents Light
    /// </summary>
    public class EllipseColorConverter
    {
        SolidColorBrush Black;
        SolidColorBrush Yellow;
        SolidColorBrush White;

        /// <summary>
        /// Constructor
        /// Used to initialize variables
        /// </summary>
        public EllipseColorConverter()
        {
            Black = new SolidColorBrush(Colors.Black);
            Yellow = new SolidColorBrush(Colors.Yellow);
            White = new SolidColorBrush(Colors.White);
        }
       
        /// <summary>
        /// Converts a GameColor i.e. Dark,Light to an Actual Colour
        /// Yellow or Blue or White
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public Brush GetActualEllipseColor(ColorType.Colour color)
        {
            var test = color == ColorType.Colour.Dark ? Black : color == ColorType.Colour.Light ? Yellow : White;
            return color == ColorType.Colour.Dark ? Black : color==ColorType.Colour.Light?Yellow:White;
        }
        /// <summary>
        /// Gets the game version of color based of the given color
        /// </summary>
        /// <param name="brush">Colour to be used to get the Games version of color</param>
        /// <returns></returns>
        public ColorType.Colour GetColor(Brush brush)
        {
            return brush == Black ? ColorType.Colour.Dark : ColorType.Colour.Light;
        }

    }
}
