
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
        private int unplaced;
        private int placed;
        private Cow playerCow;

        public Player(Phase playerPhase, int placed, int unplaced, Cow playerColour)// player constructor
        {
            this.playerPhase = playerPhase;
            this.unplaced = unplaced;
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
            if (placed == 2 && unplaced == 0) throw new Exception();
            if (placed < 4 && unplaced == 0) SetPhase(Phase.Flying);

        }
        public void PiecePlaced()// increases placed and decreases unplaced by one
        {
            placed++;
            unplaced--;
            if (placed < 4 && unplaced == 0) SetPhase(Phase.Flying);
            else if (unplaced == 0) SetPhase(Phase.Moving);
        }
        public int GetUnplaced()
        {
            return unplaced;
        }
    }
}
