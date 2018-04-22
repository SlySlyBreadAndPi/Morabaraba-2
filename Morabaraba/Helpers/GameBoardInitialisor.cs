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
        public GameBoardInitialisor()//Grid parent)
        {
            
        }

        /// <summary>
        /// Returns the Initilized board to be used in the current game session
        /// </summary>
        /// <returns></returns>
        public IBoard InitializeBoard()
        {
            var Nodes = new List<ICow>();
            for (int i = 0; i < 24; i++)
            {
                //var ellipse = (parent.Children[i] as Ellipse);
                Nodes.Add(new Cow(ColorType.Colour.Empty));
            }
            return new Board(Nodes, GameStates.GameState.Playing);

        }
        public IBoard InitializeBoard(List<int> p1, List<int> p2)
        {
            var Nodes = new List<ICow>();
            for (int i = 0; i < 24; i++)
            {
                if (p1.Contains(i))
                {
                    Nodes.Add(new Cow(ColorType.Colour.Dark));
                }
                else if (p2.Contains(i))
                {
                    Nodes.Add(new Cow(ColorType.Colour.Light));
                }
                else
                {
                    //var ellipse = (parent.Children[i] as Ellipse);
                    Nodes.Add(new Cow(ColorType.Colour.Empty));
                }
            }
            return new Board(Nodes, GameStates.GameState.Playing);

        }
    }
}
