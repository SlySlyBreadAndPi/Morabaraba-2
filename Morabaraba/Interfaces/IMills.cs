using System.Collections.Generic;

namespace MorabarabaNS.Classes
{
    public interface IMills
    {
        void Add(Mill mill);
        bool ContainsIndex(int index);
        List<Mill> GetMills();
    }
}