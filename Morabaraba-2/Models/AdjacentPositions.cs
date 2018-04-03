using Morabaraba_2.Models;
using Morabaraba_2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Models
{
    /// <summary>
    /// MillMapper Class is respondible for generating every possible mill in the Game
    /// </summary>
   public class AdjacentPositions
   {
        //Keeps track of every possible mill in the game
        List<List<int>> Adjacent;
        public AdjacentPositions()
        {
            GenerateMills();
        }
        /// <summary>
        /// Generates Every possible mill that could be formed in the Game
        /// </summary>
        private void GenerateMills()
        {
            Adjacent = new List<List<int>>();

            Adjacent.Add(new List<int> {1, 3, 9 });

            Adjacent.Add(new List<int> { 0, 2, 4 });

            Adjacent.Add(new List<int> { 1, 5, 14 });

            Adjacent.Add(new List<int> { 0, 6, 4,10});
            
            Adjacent.Add(new List<int> { 1, 3, 5, 7 });

            Adjacent.Add(new List<int> {2,4,8,13});

            Adjacent.Add(new List<int> {3,7,11 });

            Adjacent.Add(new List<int> {4,6,8 });

            Adjacent.Add(new List<int> {7,5,12 });

            Adjacent.Add(new List<int> {0,10,21 });

            Adjacent.Add(new List<int> {9,11,3,18 });

            Adjacent.Add(new List<int> {6,10,15 });

            Adjacent.Add(new List<int> {8,13,17 });

            Adjacent.Add(new List<int> {12,5,14,20 });

            Adjacent.Add(new List<int> {2,13,23 });

            Adjacent.Add(new List<int> {11,18,19});

            Adjacent.Add(new List<int> {15,19,17 });

            Adjacent.Add(new List<int> {16,12,20 });

            Adjacent.Add(new List<int> {10,21,19,15 });

            Adjacent.Add(new List<int> {18,16,20,22 });

            Adjacent.Add(new List<int> {19,13,23,17});

            Adjacent.Add(new List<int> {9,18,22 });

            Adjacent.Add(new List<int> {21,19,23 });

            Adjacent.Add(new List<int> { 22, 20, 14 });
        }
        /// <summary>
        /// Returns the Gnerated Mills
        /// </summary>
        /// <returns></returns>
        public List<int> GetAdjacentByIndex(int index)
        {
            return Adjacent.ElementAt(index) ?? throw new ArgumentOutOfRangeException(nameof(index));
        }
    }
}
