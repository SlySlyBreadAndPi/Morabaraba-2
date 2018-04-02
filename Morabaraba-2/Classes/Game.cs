using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Morabaraba_2.Classes
{
    /// <summary>
    /// The Game object holds the board and the two players. The board object simply holds a list of nodes. 
    /// This is the object that will be used to determine the game-state for the game's functioning.
    /// </summary>
    public class Game
    {
        

        public Game()// constructor for the Game class
        {
            CurrentBoard = currentBoard ?? throw new ArgumentNullException(nameof(currentBoard));
            this.p1 = p1 ?? throw new ArgumentNullException(nameof(p1));
            this.p2 = p2 ?? throw new ArgumentNullException(nameof(p2));
            turn = p1;
        }
        
        public void ChangeTurn()// sets the turn value to the player it doesnt equal
        {
            turn = turn == p1 ? p2 : p1;
        }

        
    }
}
