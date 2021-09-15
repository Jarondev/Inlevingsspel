using Inlevingsspel.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    class UK : Land
    {
        public UK(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = LandConstants.UKNaam;
            Groepsnaam = frmselecteren.LandGroep[3];
            Geld = LandConstants.UKGeld;
            Uni = LandConstants.UKUni;
            Fabriekentegoed = LandConstants.UKFabriekenTeGoed;
            Steenkoolpb = LandConstants.UKSteenkoolPb;
        }
    }
}
