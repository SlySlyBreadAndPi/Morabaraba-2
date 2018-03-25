﻿using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Classes
{
   public class PlayerCreator
   {
        Player one;
        Player two;
        public PlayerCreator()
        {
            one = new Player { playerColour = ColorType.Color.Dark, Mills = new List<Tuple<Cow, Cow, Cow>>(), placed = 0, Unplaced = 12, playerPhase = Phases.Phase.Stationary };
            two = new Player { playerColour = ColorType.Color.Light, Mills = new List<Tuple<Cow, Cow, Cow>>(), placed = 0, Unplaced = 12, playerPhase = Phases.Phase.Stationary };

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
