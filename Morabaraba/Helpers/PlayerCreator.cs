﻿using MorabarabaNS.Models;
using static MorabarabaNS.Models.ColorType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorabarabaNS.Classes;

namespace MorabarabaNS.Helpers
{
   public class PlayerCreator : IPlayerCreator
    {
        Player one;
        Player two;
        public PlayerCreator()
        {
            
            one = new Player(Phases.Phase.Placing,0,12,new Cow(ColorType.Colour.Dark));
            two = new Player(Phases.Phase.Placing,0,12,new Cow(ColorType.Colour.Light));
        }
        public PlayerCreator(int count)
        {
            
            one = new Player(Phases.Phase.Placing, count, new Cow(ColorType.Colour.Dark));
            two = new Player(Phases.Phase.Placing, count, new Cow(ColorType.Colour.Light));
        }
        public PlayerCreator(int count,int count2)
        {
            
            one = new Player(Phases.Phase.Placing, count, new Cow(ColorType.Colour.Dark));
            two = new Player(Phases.Phase.Placing, count2, new Cow(ColorType.Colour.Light));
        }
        /// <summary>
        /// Creates the Player one object
        /// </summary>
        /// <returns></returns>
        public IPlayer GetPlayerOne()
        {
            return one;
        }
        /// <summary>
        /// Creates the Player two object
        /// </summary>
        /// <returns></returns>
        public IPlayer GetPlayerTwo()
        {
            return two;
        }
    }
}
