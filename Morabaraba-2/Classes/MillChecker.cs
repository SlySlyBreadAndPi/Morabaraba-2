using Morabaraba_2.Helpers;
using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
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
        /// <param name="board">Current State of the Board</param>
        /// <param name="player">Current Player whos turn it is</param>
        /// <returns></returns>
        public Tuple<Player,bool> CheckForMills (ref Board board,Player player)
        {
            var adjacentsMills = map.GetAdjacentMills();
            bool exit = false;//used for breaking out of the outer loop
            TupleExtractor tupleExtractor;
            PlayerMillUpdater updater = new PlayerMillUpdater(player);
            var CowGetter = new OnBoardCowGetter(board.Nodes);
            MillUpdater millUpdater = new MillUpdater();
            BoardUpdater boardUpdater = new BoardUpdater();
            for (int i =0; i < adjacentsMills.Count; i++)
            {
                var adjacentMills = adjacentsMills[i];
                for(int k =0;k < adjacentMills.AdjacentMills.Count; k++)
                {
                    tupleExtractor = new TupleExtractor(adjacentMills.AdjacentMills[k]);
                    var index1 = tupleExtractor.GetType4TupleCow(1);
                    var index2 = tupleExtractor.GetType4TupleCow(2);
                    var index3 = tupleExtractor.GetType4TupleCow(3);
               
                    var onboard1 = CowGetter.GetCow(index1);
                    var onboard2 = CowGetter.GetCow(index2);
                    var onboard3 = CowGetter.GetCow(index3);
                    bool inAMill = onboard1.InAmill && onboard2.InAmill && onboard3.InAmill;
                    var mill = new Mill { Position1 = onboard1, Position2 = onboard2, Position3 = onboard3 };
                    if (onboard1.CowType==player.playerColour && onboard2.CowType==player.playerColour && onboard3.CowType == player.playerColour && !inAMill)
                    {
                        var newmill = millUpdater.SetMillToInAMill(onboard1, onboard2, onboard3);
                        var nodes=board.Nodes;
                        boardUpdater.UpdateBoard(ref nodes, newmill.Position1);
                        boardUpdater.UpdateBoard(ref nodes, newmill.Position2);
                        boardUpdater.UpdateBoard(ref nodes, newmill.Position3);
                        player.Mills.Add(newmill);
                        board.Nodes=nodes;
                        exit = true;
                        break;
                    }
                }
                if (exit) break;
            }
           //exit indicates whether or not we have found a mill or not see inner if statement
            return new Tuple<Player,bool>(player,exit);
        }
   }
}
