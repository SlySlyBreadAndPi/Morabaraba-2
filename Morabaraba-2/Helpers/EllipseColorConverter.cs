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
            Black = new SolidColorBrush(Colors.Red);
            Yellow = new SolidColorBrush(Colors.Yellow);
            White = new SolidColorBrush(Colors.White);
        }


        /// <summary>
        /// Converts Ellipse color to the Games representation color system
        /// </summary>
        /// <param name="color">Color of the Ellipse</param>
        /// <returns> ColorType.Color </returns>
        public ColorType.Color GetGameColor(Brush color)
        {
            return color==Black?ColorType.Color.Dark:color==Yellow?ColorType.Color.Light:ColorType.Color.Empty;
        }
        /// <summary>
        /// Converts a GameColor i.e. Dark,Light to an Actual Color
        /// Yellow or Blue or White
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public Brush GetActualEllipseColor(ColorType.Color color)
        {
            return color == ColorType.Color.Dark ? Black : color==ColorType.Color.Light?Yellow:White;
        }


    }
}
