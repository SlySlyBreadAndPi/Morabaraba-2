using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for updating 
    /// a particular players Mills
    /// </summary>
   public class PlayerMillUpdater
   {
        Player player;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="plyr">Player to be updated</param>
        public PlayerMillUpdater(Player plyr)
        {
            player = plyr;
        }
        /// <summary>
        /// Updates a Players Mills 
        /// 
        /// </summary>
        /// <param name="line">Mill to be added to the players current mill Collection</param>
        /// <returns></returns>
        public Player UpdatePlayer(Mill mill)
        {
            player.Mills.Add(mill);
            return player;
        }
   }
}
