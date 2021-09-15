using Inlevingsspel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    class Vietnam : Land
    {
        public Vietnam(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = LandConstants.VietnamNaam;
            Groepsnaam = frmselecteren.LandGroep[5];
            Geld = LandConstants.VietnamGeld;
            Waterpb = LandConstants.VietnamWaterPb;
            Oliepb = LandConstants.VietnamOliePb;
            Steenkoolpb = LandConstants.VietnamSteenkoolPb;
            Ijzerpb = LandConstants.VietnamIjzerPb;
        }
    }
}
