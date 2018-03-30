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
    /// For Instance the Color White on the Ellipse represents Nothing 
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
        /// Converts Ellipse color to the Games representation color system
        /// Determines which color to return based on whos turn it currently is
        /// </summary>
        /// <param name="turn">Color of the Ellipse</param>
        /// <returns> ColorType.Color </returns>
        public ColorType.Color GetGameColor(WhosTurn.Turn turn)
        {
            return turn==WhosTurn.Turn.Player1?ColorType.Color.Dark:ColorType.Color.Light;
        }
        /// <summary>
        /// Converts a GameColor i.e. Dark,Light to an Actual Color
        /// Yellow or Blue or White
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public Brush GetActualEllipseColor(ColorType.Color color)
        {
            var test = color == ColorType.Color.Dark ? Black : color == ColorType.Color.Light ? Yellow : White;
            return color == ColorType.Color.Dark ? Black : color==ColorType.Color.Light?Yellow:White;
        }
        /// <summary>
        /// Gets the game version of color based of the given color
        /// </summary>
        /// <param name="brush">Color to be used to get the Games version of color</param>
        /// <returns></returns>
        public ColorType.Color GetColor(Brush brush)
        {
            return brush == Black ? ColorType.Color.Dark : ColorType.Color.Light;
        }

    }
}
