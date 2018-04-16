using Morabaraba_2.Models;

namespace Morabaraba_2.Classes
{
    public interface IPlayer
    {
        Cow GetCow();
        bool GetHasLost();
        Phases.Phase GetPhase();
        int GetUnplaced();
        void PieceKilled();
        void PiecePlaced();
        void SetPhase(Phases.Phase phase);
    }
}