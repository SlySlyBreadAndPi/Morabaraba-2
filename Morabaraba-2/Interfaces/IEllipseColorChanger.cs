using System.Windows.Controls;
using System.Windows.Shapes;
using Morabaraba_2.Classes;
using Morabaraba_2.Models;

namespace Morabaraba_2.Helpers
{
    public interface IEllipseColorChanger
    {
        Ellipse changeColor(Ellipse cow, ColorType.Colour color);
        void ChangeColor(ref Ellipse cow, ColorType.Colour color);
        void ChangeColor(ref Grid piecesParent, Board tempBoard);
    }
}