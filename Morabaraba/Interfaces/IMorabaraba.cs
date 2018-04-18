using MorabarabaNS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MorabarabaNS.Models.Phases;

namespace MorabarabaNS.Interfaces
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
