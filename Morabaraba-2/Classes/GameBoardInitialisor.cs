using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Classes
{
    /// <summary>
    /// Responsible for initilizing the Gameboard to be used in the current session 
    /// </summary>
    public class GameBoardInitialisor
    {
        Board gameBoard;
        public GameBoardInitialisor()
        {
            var tempNodes = new List<Cow>();
            for(int i =0; i < 24; i++)
            {
                tempNodes.Add(new Cow { CowType = ColorType.Color.Empty, IndexonBoard = i });
            }
            gameBoard = new Board { Nodes = tempNodes, State = GameStates.GameState.Playing };
        }
        /// <summary>
        /// Returns the Initilized board to be used in the current game session
        /// </summary>
        /// <returns></returns>
        public Board InitializeBoard()
        {
            return gameBoard;
        }
    }
}
