using Morabaraba_2.Classes;
using Morabaraba_2.Models;

namespace Morabaraba_2.Helpers
{
    public interface IEllipseColorChanger
    {
        Cow changeColor(Cow cow, ColorType.Colour color);
        void ChangeColor(ref Cow cow, ColorType.Colour color);
        //void ChangeColor(ref Cow piecesParent, Board tempBoard);
    }
}