using System.Collections.Generic;

namespace MorabarabaNS.Classes
{
    public interface IBoard
    {
        bool CheckIndexForMill(int index, IPlayer player);
        void setTemp(int index);
        void Moving(int index);
        bool isAdjacent(int index);
        bool ContainsCowNotinMill(IPlayer player);
        List<int> GetAdjacent(int index);
        ICow GetNode(int index);
        List<ICow> GetNodes();
        void SetEmpty(int index);
        void SetNode(int index, ICow cow);
        int CowsOnBoard();

        bool PlaceCow(int index, IPlayer player);
    }
}