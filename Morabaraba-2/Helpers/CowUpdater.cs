using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for updating a cow
    /// </summary>
   public class CowUpdater
   {
        Cow OldCow;
        private Grid board;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="oldCow"></param>
        public CowUpdater(Cow oldCow)
        {
            OldCow = oldCow;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="children"></param>
        public CowUpdater(Grid children)
        {
            board= children;
        }

        /// <summary>
        /// Updates a cow at the specifed index
        /// </summary>
        /// <param name="nodes">Cow list</param>
        /// <param name="index">index on board</param>
        /// <param name="newCow">Cow to be added or used to update the old cow</param>
        public void Update (ref List<Cow> nodes ,int index,Cow newCow)
        {
            OldCow = newCow;
            nodes[index] = newCow;
        }
        /// <summary>
        /// Fall back function
        /// </summary>
        /// <returns></returns>
        public Cow GetOldCow()
        {
            return OldCow;
        }
        /// <summary>
        /// Updates a cow on the Human readable Version of the board
        /// </summary>
        /// /// <param name="newCow">Cow to be added or used to update the old cow</param>
        public Grid Update(Cow newCow)
        {
            OldCow = newCow;
            EllipseColorChanger changer = new EllipseColorChanger();
            EllipseIndexToNameConverter converter = new EllipseIndexToNameConverter();
            string name = converter.ConvertIndex(newCow.IndexonBoard);
            for (int i = 0; i < board.Children.Count; i++)
            {
                var ellipse = board.Children[i] as Ellipse;
                if (ellipse.Name == name)
                {
                    changer.ChangeColor(ref ellipse, ColorType.Color.Empty);
                    board.Children[i] = ellipse;
                    break;
                }
            }
            return board;
        }
    }
}
