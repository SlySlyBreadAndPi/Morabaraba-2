using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for converting an Ellipse Name to an index
    /// For Instance One -> 1 
    /// </summary>
   public  class EllipseNameToIndexConverter
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EllipseNameToIndexConverter()
        {

        }
        public int ConvertNameToIndex(string Stringindex)
        {
            int defualtIndex = -1;//if we cant find the index
            switch (Stringindex)
            {
                case "a1":
                    defualtIndex = 0;
                    break;
                case "a4":
                    defualtIndex = 1;
                    break;
                case "a7":
                    defualtIndex = 2;
                    break;
                case "b2":
                    defualtIndex = 3;
                    break;
                case "b4":
                    defualtIndex = 4;
                    break;
                case "b6":
                    defualtIndex = 5;
                    break;
                case "c3":
                    defualtIndex = 6;
                    break;
                case "c4":
                    defualtIndex = 7;
                    break;
                case "c5":
                    defualtIndex = 8;
                    break;
                case "d1":
                    defualtIndex = 9;
                    break;
                case "d2":
                    defualtIndex = 10;
                    break;
                case "d3":
                    defualtIndex = 11;
                    break;
                case "d5":
                    defualtIndex = 12;
                    break;
                case "d6":
                    defualtIndex = 13;
                    break;
                case "d7":
                    defualtIndex = 14;
                    break;
                case "e3":
                    defualtIndex = 15;
                    break;
                case "e4":
                    defualtIndex = 16;
                    break;
                case "e5":
                    defualtIndex = 17;
                    break;
                case "f2":
                    defualtIndex = 18;
                    break;
                case "f4":
                    defualtIndex = 19;
                    break;
                case "f6":
                    defualtIndex = 20;
                    break;
                case "g1":
                    defualtIndex = 21;
                    break;
                case "g4":
                    defualtIndex = 22;
                    break;
                case "g7":
                    defualtIndex = 23;
                    break;
            }
            return defualtIndex;

        }
    }
}
