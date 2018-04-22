using MorabarabaNS.Models;

namespace MorabarabaNS.Classes
{
    public interface IPlayer
    {
        ICow GetCow();
        bool GetHasLost();
        Phases.Phase GetPhase();
        int GetUnplaced();
        void PieceKilled();
        void PiecePlaced();
        void SetPhase(Phases.Phase phase);
        void SetHasLost();
    }
}