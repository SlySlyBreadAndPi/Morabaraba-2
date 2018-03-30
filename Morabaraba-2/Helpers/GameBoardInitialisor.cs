using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for initilizing the Gameboard to be used in the current session 
    /// </summary>
    public class GameBoardInitialisor
    {
        Board gameBoard;
        public GameBoardInitialisor(Grid parent)
        {
            var tempNodes = new List<Cow>();
            var converter = new EllipseNameToIndexConverter();
            for(int i =0; i < 24; i++)
            {
                var ellipse = (parent.Children[i] as Ellipse);
                tempNodes.Add(new Cow { CowType = ColorType.Color.Empty, IndexonBoard = converter.ConvertNameToIndex(ellipse.Name) });
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
