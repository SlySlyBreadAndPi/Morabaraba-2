using Morabaraba_2.Models;

namespace Morabaraba_2.Classes
{
    public interface ICow
    {
        ColorType.Colour Get();
        void Set(ColorType.Colour c);
    }
}