using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;
using static Morabaraba_2.Models.ColorType;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for Changing an Ellipse Background After Each Turn
    /// </summary>
    public class EllipseColorChanger
    {
        public EllipseColorChanger()
        {

        }
        public void ChangeColor(ref Ellipse cow, Models.ColorType.Color color)
        {
            EllipseColorConverter converter = new EllipseColorConverter();
            cow.Fill = converter.GetActualEllipseColor(color);
        }
    }
}
