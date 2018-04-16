using System.Windows.Media;
using Morabaraba_2.Models;

namespace Morabaraba_2.Helpers
{
    public interface IEllipseColorConverter
    {
        Brush GetActualEllipseColor(ColorType.Colour color);
        ColorType.Colour GetColor(Brush brush);
    }
}