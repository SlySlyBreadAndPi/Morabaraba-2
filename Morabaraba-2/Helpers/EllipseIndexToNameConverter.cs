using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Converts an Index to its actual string representatio
    /// E.g. 0=zero
    /// </summary>
   public class EllipseIndexToNameConverter
    {
        public EllipseIndexToNameConverter()
        {

        }
        public string ConvertIndex(int index)
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
