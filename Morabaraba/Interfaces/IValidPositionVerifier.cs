using System.Collections.Generic;
using MorabarabaNS.Classes;

namespace MorabarabaNS.Helpers
{
    public interface IValidPositionVerifier
    {
        bool VerifyAdjacent(List<int> xs);
        bool VerifyEmpty(int cow);
        bool VerifyOwnByPlayer(int cow, IPlayer player);
        bool VerifyMoving(int index, IPlayer player);
        bool VerifyMoving2(int index);
        bool VerifyPlacing(int index);
        bool VerifyFlying(int index, IPlayer player);
        bool VerifyFlying2(int index);
        bool VerifyCanShoot(int index, IPlayer player);
    }
}