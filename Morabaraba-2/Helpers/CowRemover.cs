using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for removing a cow from the board
    /// </summary>
    public class CowRemover
    {
        Board board;
        public CowRemover(Board board)
        {
            this.board = board;
        }
        /// <summary>
        /// Removes a cow at the specified postion on the board
        /// used for Highlighting a players cows that are placed on the board
        /// </summary>
        /// <param name="board">Current sessions board</param>
        /// <param name="cow">the cow to be removed from the board</param>
        /// <returns></returns>
        public Board RemoveCow(Cow cow)
        {
            for(int i =0;i < board.Nodes.Count; i++)
            {
                if (board.Nodes[i] == cow)
                {
                  board.Nodes[i].CowType = ColorType.Color.Empty;//make the postion on the board empty
                    break;
                }
            }
            return board;
        }
        /// <summary>
        /// Removes a cow on the Games version of the board (from the Board object) as well as
        /// The Human readable Board
        /// </summary>
        /// <param name="grid">Human readable board</param>
        /// <param name="onBoardEllipse">The Ellipse that the user clicked on</param>
        /// <param name="cow">The Games version of the cow equivalent to the ellipse the user clicked on</param>
        /// <returns>Updated Board</returns>
        public  Board RemoveCow(ref Grid grid, Ellipse onBoardEllipse, Cow cow)
        {
            EllipseColorChanger changer = new EllipseColorChanger();
            OnBoardCowGetter cowGetter = new OnBoardCowGetter(board.Nodes);
            var nodes = board.Nodes;
            for(int i = 0; i < nodes.Count; i++)
            {
                if (board.Nodes[i] == cow)
                {
                    Cow temp = cowGetter.GetCow(i);
                    CowUpdater updater = new CowUpdater(temp);
                    changer.ChangeColor(ref temp ,ColorType.Color.Empty);
                    updater.Update(ref nodes, i, temp);
                    break;
                }
            }
            CowGetter getter = new CowGetter(grid.Children);
            for(int i=0; i < grid.Children.Count; i++)
            {
                Ellipse temp = getter.GetEllipse(i);
                if (temp.Name == onBoardEllipse.Name)
                {
                    changer.changeColor(temp, ColorType.Color.Empty);
                    break;
                }
            }
            return board;
        }
    }
}
