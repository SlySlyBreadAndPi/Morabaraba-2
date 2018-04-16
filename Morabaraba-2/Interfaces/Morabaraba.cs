using Morabaraba_2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Morabaraba_2.Models.Phases;

namespace Morabaraba_2.Interfaces
{
    public interface IMorabaraba
    {
        bool PlaceCow(int index);
        Board Move(int index);
        Player Turn(bool turn);
        void CowPlaced();
        void CowKilled();
        void NextTurn();
        void SetTurnPhase(Phase phase);
        Cow TurnCow();
        List<string> InfoToString();
        string instructions();
        bool GetPlayerLostOrNot();
        List<Cow> GetBoard();
        bool getTurn();
    }
}
