
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Models
{
    /// <summary>
    /// This object holds the phase that the player is in, the number of cows they need to place, which will then change their phase
    /// placed simply counts how many cows have been placed by the player so far
    /// playerColour is the colour that the player's cows will be in the game
    /// </summary>
    public class Player
    {
        phase pPhase { get; set;}
        int Unplaced { get; set;}
        int placed { get; set; }
        Cow playerColour { get; set; }
    }
}
