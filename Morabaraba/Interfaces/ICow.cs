using MorabarabaNS.Models;

namespace MorabarabaNS.Classes
{
    public interface ICow
    {
        ColorType.Colour Get();
        void Set(ColorType.Colour c);
    }
}