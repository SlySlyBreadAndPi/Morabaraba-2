using System;
using System.Collections.Generic;
using System.Text;

namespace MorabarabaNS.Interfaces
{
   public interface ICommand
    {
        void Execute();
        EventHandler EventHandler();
    }
}
