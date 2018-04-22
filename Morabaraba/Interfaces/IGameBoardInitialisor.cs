using MorabarabaNS.Classes;
using System.Collections.Generic;

namespace MorabarabaNS.Helpers
{
    public interface IGameBoardInitialisor
    {
        IBoard InitializeBoard();

        IBoard InitializeBoard(List<int> p1Positions, List<int> p2Positions);
    }
}