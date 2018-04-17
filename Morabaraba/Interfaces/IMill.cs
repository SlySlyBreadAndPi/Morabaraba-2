using System.Collections.Generic;

namespace MorabarabaNS.Classes
{
    public interface IMill
    {
        bool ContainsIndex(int index);
        List<int> ToList();
    }
}