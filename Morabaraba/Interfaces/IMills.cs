using System.Collections.Generic;

namespace MorabarabaNS.Classes
{
    public interface IMills
    {
        void Add(IMill mill);
        bool ContainsIndex(int index);
        List<IMill> GetMills();
    }
}