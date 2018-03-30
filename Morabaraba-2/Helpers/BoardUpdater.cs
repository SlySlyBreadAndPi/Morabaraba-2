using Morabaraba_2.Helpers;
using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for updating the board
    /// </summary>
    public class BoardUpdater
    {
        Board internalBoard;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="board"></param>
        public BoardUpdater()
        {
        }
        /// <summary>
        /// Updates the board given a cow 
        /// </summary>
        /// <param name="cow">cow to be inserted into the list</param>
        /// <returns></returns>
        public void UpdateBoard(ref List<Cow> board,Cow cow)
        {
            OnBoardCowGetter getter = new OnBoardCowGetter(board);
            for(int i =0; i < board.Count; i++)
            {
                Cow temp = getter.GetCow(i);
                CowUpdater updater = new CowUpdater(temp);
                if (temp.IndexonBoard == cow.IndexonBoard)
                {
                    updater.Update(ref board, i, cow);
                    break;
                }
            }

        }
    }
}
