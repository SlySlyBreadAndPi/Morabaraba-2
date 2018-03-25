using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Morabaraba_2.Models
{
    /// <summary>
    /// The Game object holds the board and the two players. The board object simply holds a list of nodes. 
    /// This is the object that will be used to determine the game-state for the game's functioning.
    /// </summary>
    public class Game
    {
        public Board CurrentBoard { get;  set; }
        public Player p1 { get;  set; }
        public Player p2 {get; set;}
    }
}
