using System.Collections.Generic;
using Morabaraba_2.Classes;

namespace Morabaraba_2.Helpers
{
    public interface IValidPositionVerifier
    {
        bool VerifyAdjacent(List<int> xs);
        bool VerifyEmpty(int cow);
        bool VerifyOwnByPlayer(int cow, Player player);
    }
}