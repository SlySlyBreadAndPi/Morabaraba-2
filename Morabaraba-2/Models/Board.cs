using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Models
{
    /// <summary>
    /// The board class holds a list of cows that are called nodes because each cow and its index within the list represents a node on the board.
    /// The index that the cow occupies will be used to move cows around the board, using a method that translates the index position within the list to a board position.
    /// It also holds gamestate to show whether the game is in progress or over.
    /// </summary>
    class Board
    {
       List<Cow> Nodes { get; set; }
       GameState State { get; set; }
    }
}
