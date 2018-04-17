using System.Collections.Generic;

namespace MorabarabaNS.Classes
{
    public interface IBoard
    {
        bool CheckIndexForMill(int index, Player player);
        bool ContainsCowNotinMill(Player player);
        List<int> GetAdjacent(int index);
        Cow GetNode(int index);
        List<Cow> GetNodes();
        void SetEmpty(int index);
        void SetNode(int index, Cow cow);
    }
}