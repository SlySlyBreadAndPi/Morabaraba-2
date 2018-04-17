using System.Collections.Generic;
using MorabarabaNS.Classes;

namespace MorabarabaNS.Helpers
{
    public interface IValidPositionVerifier
    {
        bool VerifyAdjacent(List<int> xs);
        bool VerifyEmpty(int cow);
        bool VerifyOwnByPlayer(int cow, Player player);
    }
}