using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
using Morabaraba_2.Helpers;
using Morabaraba_2.Models;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for highlighting an opponents cow 
    /// so that a player can pick which one to remove
    /// </summary>
    public class CowHighLighter
    {
        private Board board;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="board"></param>
        public CowHighLighter(Board board)
        {
            this.board = board;
        }
        /// <summary>
        /// Highlights the Opponents cows to removes the other players cows from the board
        /// making it easier to pick which cow to remove from
        /// The opponents cow set
        /// </summary>
        /// <param name="opponent"></param>
        /// <returns></returns>
        public Board HighLightCows(Player curentPlayer, ref Grid piecesParent)
        {
            var changer = new EllipseColorChanger();
            int count = 0;
            var newList = new List<Cow>();
            for (int i =0; i <board.Nodes.Count; i++)
            {
                var currentNode = board.Nodes[i];
                if (currentNode.CowType == curentPlayer.playerColour)
                {
                    count++;
                    newList.Add(new Cow { IndexonBoard = currentNode.IndexonBoard, CowType = ColorType.Color.Empty });
                   // tempBoard.Nodes[currentNode.IndexonBoard].CowType = ColorType.Color.Empty;
                  //  var ellipse = (piecesParent.Children[currentNode.IndexonBoard] as Ellipse);
                   // changer.ChangeColor(ref ellipse, ColorType.Color.Empty);
                }
                else
                {
                    newList.Add(currentNode);
                }
            }
            return new Board { Nodes = newList, State = board.State };
            }
        /// <summary>
        /// Removes a cow from the board
        /// </summary>
        /// <param name="pos">cow position on the board</param>
        /// <returns>new Board</returns>
        public Board GetOriginalBoard(ref Grid grid,Cow pos,Ellipse ellipseClickedOn)
        {
            CowRemover cowRemover = new CowRemover(board);
            EllipseNameToIndexConverter converter = new EllipseNameToIndexConverter();
            int IndexonGrid = converter.ConvertNameToIndex(ellipseClickedOn.Name);
            CowGetter getter = new CowGetter(grid.Children);
            Ellipse onBoardEllipse = getter.GetEllipse(IndexonGrid);
            return cowRemover.RemoveCow(ref grid,onBoardEllipse,pos);
        }
    }
}
