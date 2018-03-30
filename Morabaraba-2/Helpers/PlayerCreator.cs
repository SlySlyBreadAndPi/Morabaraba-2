using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
   public class PlayerCreator
   {
        Player one;
        Player two;
        public PlayerCreator(SelectedColor color)
        {
            var unusedColor = color.PlayerOneColor == ColorType.Color.Dark ? ColorType.Color.Light : ColorType.Color.Dark;
            one = new Player { playerColour = color.PlayerOneColor, Mills = new List<Mill>(), placed = 0, Unplaced = 12, playerPhase = Phases.Phase.Stationary };
            two = new Player { playerColour = unusedColor, Mills = new List<Mill>(), placed = 0, Unplaced = 12, playerPhase = Phases.Phase.Stationary };

        }
        /// <summary>
        /// Creates the Player one object
        /// </summary>
        /// <returns></returns>
        public Player CreatePlayerOne()
        {
            return one;
        }
        /// <summary>
        /// Creates the Player two object
        /// </summary>
        /// <returns></returns>
        public Player CreatePlayerTwo()
        {
            return two;
        }
    }
}
