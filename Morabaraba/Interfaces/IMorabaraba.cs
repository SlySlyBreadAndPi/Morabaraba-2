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
        IBoard Move(int index);
        IPlayer Turn(bool turn);
        void CowPlaced();
        void CowKilled();
        void NextTurn();
        void SetTurnPhase(Phase phase);
        ICow TurnCow();
        List<string> InfoToString();
        string instructions();
        bool GetPlayerLostOrNot();
        List<ICow> GetBoard();
        bool getTurn();

        void Changeremoving();
    }
}
