using System.Collections.Generic;

namespace Morabaraba_2.Classes
{
    public interface IMills
    {
        void Add(Mill mill);
        bool ContainsIndex(int index);
        List<Mill> GetMills();
    }
}