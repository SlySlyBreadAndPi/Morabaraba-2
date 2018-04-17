using MorabarabaNS.Models;
using MorabarabaNS.Classes;
using System.Collections.Generic;

namespace MorabarabaNS.Helpers
{
    /// <summary>
    /// Responsible for initilizing the Gameboard to be used in the current session 
    /// </summary>
    public class GameBoardInitialisor : IGameBoardInitialisor
    {
        Board gameBoard;
        public GameBoardInitialisor()//Grid parent)
        {
            var Nodes = new List<Cow>();
            for(int i =0; i < 24; i++)
            {
                //var ellipse = (parent.Children[i] as Ellipse);
                Nodes.Add(new Cow(ColorType.Colour.Empty));
            }
            gameBoard = new Board(Nodes,GameStates.GameState.Playing);
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
