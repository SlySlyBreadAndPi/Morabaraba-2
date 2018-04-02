using Morabaraba_2.Models;
using static Morabaraba_2.Models.ColorType;
using Morabaraba_2.Helpers;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Morabaraba_2.Classes
{
    /// <summary>
    /// This class holds the current game session between two players
    /// </summary>

    public class Morabaraba
    {
        private Board CurrentBoard;
        private Player p1;
        private Player p2;
        private Player turn;
        PlayerCreator creator;
        GameBoardInitialisor init;
        /// <summary>
        /// Constructor
        /// </summary>
        public Morabaraba(Grid parent,Colour color)
        {
            init = new GameBoardInitialisor(parent);
            creator = new PlayerCreator(color);

        }
        /// <summary>
        /// Initialises the Current Game Session Objects
        /// </summary>
        /// <param name="parent"></param>
        public void Init()
        {
            
           // currentGameState = new Game(init.InitializeBoard(),creator.GetPlayerOne(),creator.GetPlayerTwo());
        }
        /// <summary>
        /// Responsible for Making allowing the player to make a move 
        /// This method is the intermediary between the UI and 
        /// the rest of the game
        /// </summary>
        /// <param name="pos">The cow postion the Player whises to place a cow in</param>
        /// <param name="turn">Next Players turn</param>
        /// <returns></returns>
       
        /// <summary>
        /// Removes an opponents cow from the board
        /// </summary>
        /// <param name="ellipseClicked">Cow that was clicked on and to be removed</param>
        /// <param name="piecesParent">The Actual board i.e. human readable board</param>
        ///<param name="otherPlayer">used for checking if the other player has placed all they cows </param>


        /// <summary>
        /// Gets the Current state of the Board
        /// </summary>
        /// <returns> Board </returns>
       
        /// <summary>
        /// Returns a player 
        /// </summary>
        /// <param name="turn">Used for determining which player to return</param>
        /// <returns></returns>
       
    }
}
