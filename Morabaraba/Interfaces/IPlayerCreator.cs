using MorabarabaNS.Classes;

namespace MorabarabaNS.Helpers
{
    public interface IPlayerCreator
    {
        IPlayer GetPlayerOne();
        IPlayer GetPlayerTwo();
    }
}