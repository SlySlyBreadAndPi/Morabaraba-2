using Morabaraba_2.Models;
using static Morabaraba_2.Models.ColorType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Morabaraba_2.Classes;

namespace Morabaraba_2.Helpers
{
   public class PlayerCreator
   {
        Player one;
        Player two;
        public PlayerCreator(Colour color)
        {
            var unusedColor = color == ColorType.Colour.Dark ? ColorType.Colour.Light : ColorType.Colour.Dark;
            one = new Player(Phases.Phase.Stationary,0,12,new Cow(color));
            two = new Player(Phases.Phase.Stationary,0,12,new Cow(unusedColor));
        }
        /// <summary>
        /// Creates the Player one object
        /// </summary>
        /// <returns></returns>
        public Player GetPlayerOne()
        {
            return one;
        }
        /// <summary>
        /// Creates the Player two object
        /// </summary>
        /// <returns></returns>
        public Player GetPlayerTwo()
        {
            return two;
        }
    }
}
