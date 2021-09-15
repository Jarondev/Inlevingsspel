using Inlevingsspel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    class USA : Land
    {
        public USA(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = LandConstants.USANaam;
            Groepsnaam = frmselecteren.LandGroep[1];
            Geld = LandConstants.USAGeld;
            Uni = LandConstants.USAUni;
            Fabriekentegoed = LandConstants.USAFabriekenTeGoed;
            Waterpb = LandConstants.USAWaterPb;
            Oliepb = LandConstants.USAOliePb;
            Ijzerpb = LandConstants.USAIjzerPb;
        }
    }
}
