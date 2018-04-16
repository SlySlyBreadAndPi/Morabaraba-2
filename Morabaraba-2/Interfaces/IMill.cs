using System.Collections.Generic;

namespace Morabaraba_2.Classes
{
    public interface IMill
    {
        bool ContainsIndex(int index);
        List<int> ToList();
    }
}