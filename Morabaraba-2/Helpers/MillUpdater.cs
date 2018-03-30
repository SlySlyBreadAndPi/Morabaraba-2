using Morabaraba_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morabaraba_2.Helpers
{
    /// <summary>
    /// Responsible for updating a mill
    /// </summary>
    public class MillUpdater
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MillUpdater()
        {

        }

        /// <summary>
        /// Updates a Mills InAmill property to true
        /// </summary>
        /// <param name="onboard1">Cow on board</param>
        /// <param name="onboard2">Cow on board</param>
        /// <param name="onboard3">Cow on board</param>
        /// <returns>new Mill</returns>
        public Mill SetMillToInAMill(Cow onboard1,Cow onboard2,Cow onboard3)
        {
            return new Mill { Position1 = new Cow { IndexonBoard = onboard1.IndexonBoard, CowType = onboard1.CowType, InAmill = true }, Position2 = new Cow { IndexonBoard = onboard2.IndexonBoard, CowType = onboard2.CowType, InAmill = true }, Position3 = new Cow { IndexonBoard = onboard3.IndexonBoard, CowType = onboard3.CowType, InAmill = true } };
        }
    }
}
