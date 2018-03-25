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
                case "zero":
                    defualtIndex = 0;
                    break;
                case "one":
                    defualtIndex = 1;
                    break;
                case "two":
                    defualtIndex = 2;
                    break;
                case "three":
                    defualtIndex = 3;
                    break;
                case "four":
                    defualtIndex = 4;
                    break;
                case "five":
                    defualtIndex = 5;
                    break;
                case "six":
                    defualtIndex = 6;
                    break;
                case "seven":
                    defualtIndex = 7;
                    break;
                case "eight":
                    defualtIndex = 8;
                    break;
                case "nine":
                    defualtIndex = 9;
                    break;
                case "ten":
                    defualtIndex = 10;
                    break;
                case "eleven":
                    defualtIndex = 11;
                    break;
                case "twelve":
                    defualtIndex = 12;
                    break;
                case "thirteen":
                    defualtIndex = 13;
                    break;
                case "fourteen":
                    defualtIndex = 14;
                    break;
                case "fifteen":
                    defualtIndex = 15;
                    break;
                case "sixteen":
                    defualtIndex = 16;
                    break;
                case "seventeen":
                    defualtIndex = 17;
                    break;
                case "eighteen":
                    defualtIndex = 18;
                    break;
                case "nineteen":
                    defualtIndex = 19;
                    break;
                case "tweenty":
                    defualtIndex = 20;
                    break;
                case "tweentyone":
                    defualtIndex = 21;
                    break;
                case "tweentytwo":
                    defualtIndex = 22;
                    break;
                case "tweentythree":
                    defualtIndex = 23;
                    break;
            }
            return defualtIndex;

        }
    }
}
