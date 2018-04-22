using MorabarabaNS.Models;
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
        public PlayerCreator(Colour color)
        {
            var unusedColor = color == ColorType.Colour.Dark ? ColorType.Colour.Light : ColorType.Colour.Dark;
            one = new Player(Phases.Phase.Placing,0,12,new Cow(color));
            two = new Player(Phases.Phase.Placing,0,12,new Cow(unusedColor));
        }
        public PlayerCreator(Colour color, int count)
        {
            var unusedColor = color == ColorType.Colour.Dark ? ColorType.Colour.Light : ColorType.Colour.Dark;
            one = new Player(Phases.Phase.Placing, count, new Cow(color));
            two = new Player(Phases.Phase.Placing, count, new Cow(unusedColor));
        }
        public PlayerCreator(Colour color, int count,int count2)
        {
            var unusedColor = color == ColorType.Colour.Dark ? ColorType.Colour.Light : ColorType.Colour.Dark;
            one = new Player(Phases.Phase.Placing, count, new Cow(color));
            two = new Player(Phases.Phase.Placing, count2, new Cow(unusedColor));
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
