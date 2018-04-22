using MorabarabaNS.Models;
using System.Collections.Generic;
using MorabarabaNS.Classes;
namespace MorabarabaNS.Helpers
{
    /// <summary>
    ///Responsible for Verifying if a specific 
    ///Position on the board is safe to be played or not
    ///This will prevent a user from playing at an already occupied position
    /// </summary>
    public class ValidPositionVerifier : IValidPositionVerifier
    {
        IBoard board;

        public ValidPositionVerifier(IBoard board)
        {
            this.board = board;
        }
        /// <summary>
        /// The main guy 
        /// Uses the opponents color to determine whether a position is valid
        /// or not
        /// </summary>
        /// <param name="board">Actual Human readable Board</param>
        /// <param name="cow">The Proposed position to be played in</param>
        /// <param name="opponent">The Other Player</param>
        /// <returns></returns>
        public bool VerifyEmpty(int cow)
        {
            return (board.GetNode(cow).Get() == ColorType.Colour.Empty);
        }

        //Checks if a position on the board belongs to the player being passed to it
        public bool VerifyOwnByPlayer(int cow, IPlayer player)
        {
            return (board.GetNode(cow).Get() == player.GetCow().Get());
        }

        public bool VerifyAdjacent(List<int> xs)
        {
            foreach(int i in xs)
            {
                if (VerifyEmpty(i)) return true;
            }
            return false;
        }

        public bool VerifyMoving(int index, IPlayer player)
        {
            return VerifyOwnByPlayer(index, player) && VerifyAdjacent(board.GetAdjacent(index));
        }
        public bool VerifyMoving2(int index)
        {
            return VerifyEmpty(index) && board.isAdjacent(index);
        }
        public bool VerifyPlacing(int index)
        {
            return VerifyEmpty(index);
        }
        public bool VerifyFlying(int index, IPlayer player)
        {
            return VerifyOwnByPlayer(index, player);
        }
        public bool VerifyFlying2(int index)
        {
            return VerifyEmpty(index);
        }
        public bool VerifyCanShoot(int index, IPlayer  player)
        {
            bool inMill = board.CheckIndexForMill(index, player);
            bool allInMill = !board.ContainsCowNotinMill(player);
            bool ownedByOpponent = VerifyOwnByPlayer(index, player);
            return ownedByOpponent && (inMill == allInMill);
        }
    }
}
