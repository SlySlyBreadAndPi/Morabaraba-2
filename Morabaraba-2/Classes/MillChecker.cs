using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Classes
{
    /// <summary>
    /// Responsible for Checking if a player has formed a Mill
    /// Uses the MillMaper class
    /// </summary>
   public class MillChecker
   {
        MillMaper map;
        public MillChecker()
        {
            map = new MillMaper();
        }
        /// <summary>
        /// Check if the Player has formed a Mill or not if yes
        /// Update the players Mill List
        /// else return the player as is.
        /// </summary>
        /// <param name="board"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public Player CheckForMills (Board board,Player player)
        {
            var adjacentsMills = map.GetAdjacentMills();
            bool exit = false;//used for breaking out of the outer loop
           for(int i =0; i < adjacentsMills.Count; i++)
            {
                var adjacentMills = adjacentsMills[i];
                for(int k =0;k < adjacentMills.AdjacentMills.Count; k++)
                {
                    var index1 = adjacentMills.AdjacentMills[k].Item1;
                    var index2 = adjacentMills.AdjacentMills[k].Item2;
                    var index3 = adjacentMills.AdjacentMills[k].Item3;
                    var onboard1 = board.Nodes[index1.IndexonBoard];
                    var onboard2 = board.Nodes[index2.IndexonBoard];
                    var onboard3 = board.Nodes[index3.IndexonBoard];
                    if (onboard1.CowType==player.playerColour && onboard2.CowType==player.playerColour && onboard3.CowType == player.playerColour)
                    {
                        player.Mills.Add(new Tuple<Cow, Cow, Cow>(onboard1, onboard2, onboard3));
                        exit = true;
                        break;
                    }

                }
                if (exit) break;
            }
            return player;
        }
   }
}
