using MorabarabaNS.Models;
using MorabarabaNS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorabarabaNS.Models
{
    /// <summary>
    /// MillMapper Class is respondible for generating every possible mill in the Game
    /// </summary>
   public class PossibleMills
   {
        //Keeps track of every possible mill in the game
        List<Mills> AllPossibleMills;
        public PossibleMills()
        {
            GenerateMills();
        }
        /// <summary>
        /// Generates Every possible mill that could be formed in the Game
        /// </summary>
        private void GenerateMills()
        {
            AllPossibleMills = new List<Mills>();
    
            List<Mill> Adjacent = new List<Mill>();
            Adjacent.Add(new Mill(1,2,0));
            Adjacent.Add(new Mill(3,6,0));
            Adjacent.Add(new Mill(9,21,0));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(0, 2, 1));
            Adjacent.Add(new Mill(4, 7, 1));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(1, 0, 2));
            Adjacent.Add(new Mill(5, 8, 2));
            Adjacent.Add(new Mill(14, 23, 2));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();


            Adjacent.Add(new Mill(0,6,3));
            Adjacent.Add(new Mill(4,5,3));
            Adjacent.Add(new Mill(18,10,3));
            AllPossibleMills.Add(new Mills (Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(1,7,4));
            Adjacent.Add(new Mill(3,5,4));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(2,8,5));
            Adjacent.Add(new Mill(4,3,5));
            Adjacent.Add(new Mill(13,20,5));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(7,8,6));
            Adjacent.Add(new Mill(3,0,6));
            Adjacent.Add(new Mill(11,15,6));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(6,8,7));
            Adjacent.Add(new Mill(4,1,7));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(12,17,8));
            Adjacent.Add(new Mill(5,2,8));
            Adjacent.Add(new Mill(6,7,8));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(10,11,9));
            Adjacent.Add(new Mill(0,21,9));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(11,9,10));
            Adjacent.Add(new Mill(3,18,10));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(9,10, 11));
            Adjacent.Add(new Mill(6,15, 11));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(8, 17, 12));
            Adjacent.Add(new Mill(13, 14, 12));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(12, 14, 13));
            Adjacent.Add(new Mill(5, 20, 13));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(12, 13, 14));
            Adjacent.Add(new Mill(2, 23, 14));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(17, 16, 15));
            Adjacent.Add(new Mill(11, 6, 15));
            Adjacent.Add(new Mill(18, 21, 15));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(15, 17, 16));
            Adjacent.Add(new Mill(19, 22, 16));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(15, 16, 17));
            Adjacent.Add(new Mill(12, 8, 17));
            Adjacent.Add(new Mill(20, 23, 17));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();
            
            Adjacent.Add(new Mill(19, 20, 18));
            Adjacent.Add(new Mill(3, 10, 18));
            Adjacent.Add(new Mill(15, 21, 18));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(16, 22, 19));
            Adjacent.Add(new Mill(20, 18, 19));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(19, 18, 20));
            Adjacent.Add(new Mill(23, 17, 20));
            Adjacent.Add(new Mill(13, 5, 20));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(22, 23, 21));
            Adjacent.Add(new Mill(9, 0, 21));
            Adjacent.Add(new Mill(18, 15, 21));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

            Adjacent.Add(new Mill(21, 23, 22));
            Adjacent.Add(new Mill(19, 16, 22));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();


            Adjacent.Add(new Mill(21, 22, 23));
            Adjacent.Add(new Mill(20, 17, 23));
            Adjacent.Add(new Mill(14, 2, 23));
            AllPossibleMills.Add(new Mills(Adjacent));
            Adjacent = new List<Mill>();

           
        }
        /// <summary>
        /// Returns the Gnerated Mills
        /// </summary>
        /// <returns></returns>
        public Mills GetMillsByIndex(int index)
        {
            return AllPossibleMills.ElementAt(index) ?? throw new ArgumentOutOfRangeException(nameof(index));
        }
    }
}
