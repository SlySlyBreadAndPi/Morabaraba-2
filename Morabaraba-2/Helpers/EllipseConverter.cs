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
   public class EllipseConverter
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EllipseConverter()
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
        public string ConvertIndexToName(int index)
        {
            var defualt = "";
            switch (index)
            {
                case 0:
                    defualt = "a1";
                    break;
                case 1:
                    defualt = "a4";
                    break;
                case 2:
                    defualt = "a7";
                    break;
                case 3:
                    defualt = "b2";
                    break;
                case 4:
                    defualt = "b4";
                    break;
                case 5:
                    defualt = "b6";
                    break;
                case 6:
                    defualt = "c3";
                    break;
                case 7:
                    defualt = "c4";
                    break;
                case 8:
                    defualt = "c5";
                    break;
                case 9:
                    defualt = "d1";
                    break;
                case 10:
                    defualt = "d2";
                    break;
                case 11:
                    defualt = "d3";
                    break;
                case 12:
                    defualt = "d5";
                    break;
                case 13:
                    defualt = "d6";
                    break;
                case 14:
                    defualt = "d7";
                    break;
                case 15:
                    defualt = "e3";
                    break;
                case 16:
                    defualt = "e4";
                    break;
                case 17:
                    defualt = "e5";
                    break;
                case 18:
                    defualt = "f2";
                    break;
                case 19:
                    defualt = "f4";
                    break;
                case 20:
                    defualt = "f6";
                    break;
                case 21:
                    defualt = "g1";
                    break;
                case 22:
                    defualt = "g4";
                    break;
                case 23:
                    defualt = "g7";
                    break;
            }
            return defualt;
        }
    }
}
