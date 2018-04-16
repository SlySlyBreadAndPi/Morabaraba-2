using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Morabaraba_2.Classes;
namespace Morabaraba_2.Helpers
{
    /// <summary>
    ///Responsible for Verifying if a specific 
    ///Position on the board is safe to be played or not
    ///This will prevent a user from playing at an already occupied position
    /// </summary>
    public class ValidPositionVerifier : IValidPositionVerifier
    {
        Board board;

        public ValidPositionVerifier(Board board)
        {
            this.board = board;
        }
        /// <summary>
        /// The main guy 
        /// Uses the opponents color to determine whether a position is valid
        /// or not
        /// </summary>
        /// <param name="board">Actual Human readable Board</param>
        /// <param name="cow">The Proposed position to be played in</param>
        /// <param name="opponent">The Other Player</param>
        /// <returns></returns>
        public bool VerifyEmpty(int cow)
        {
            return (board.GetNode(cow).Get() == ColorType.Colour.Empty);
        }

        //Checks if a position on the board belongs to the player being passed to it
        public bool VerifyOwnByPlayer(int cow, Player player)
        {
            return (board.GetNode(cow).Get() == player.GetCow().Get());
        }

        public bool VerifyAdjacent(List<int> xs)
        {
            foreach(int i in xs)
            {
                if (VerifyEmpty(i)) return true;
            }
            return false;
        }
    }
}
