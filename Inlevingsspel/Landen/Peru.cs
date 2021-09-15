using Inlevingsspel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    class Peru : Land
    {
        public Peru(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = LandConstants.PeruNaam;
            Groepsnaam = frmselecteren.LandGroep[7];
            Geld = LandConstants.PeruGeld;
            Waterpb = LandConstants.PeruWaterPb;
            Oliepb = LandConstants.PeruOliePb;
            Steenkoolpb = LandConstants.PeruSteenkoolPb;
            Ijzerpb = LandConstants.PeruIjzerPb;
        }
    }
}
