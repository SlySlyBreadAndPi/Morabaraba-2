
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Morabaraba_2.Models.ColorType;
using static Morabaraba_2.Models.Phases;

namespace Morabaraba_2.Classes
{
    /// <summary>
    /// This object holds the phase that the player is in, the number of cows they need to place, which will then change their phase
    /// placed simply counts how many cows have been placed by the player so far
    /// playerColour is the colour that the player's cows will be in the game
    /// </summary>
    public class Player
    {
        private Phase playerPhase;
        private int Unplaced;
        private int placed;
        private Cow playerCow;

        public Player(Phase playerPhase, int unplaced, int placed, Cow playerColour)// player constructor
        {
            this.playerPhase = playerPhase;
            Unplaced = unplaced;
            this.placed = placed;
            this.playerCow = playerColour;
        }

        public void SetPhase(Phase phase)// sets phase of player
        {
            playerPhase = phase;
        }
        public Phase GetPhase()// returns player phase
        {
            return playerPhase;
        }
        public Cow GetCow()// returns the players cow
        {
            return playerCow;
        }
        public void PieceKilled()// reduces number of placed pieces by one
        {
            placed--;
        }
        public void PiecePlaced()// increases placed and decreases unplaced by one
        {
            placed++;
            Unplaced--;
        }
    }
}
