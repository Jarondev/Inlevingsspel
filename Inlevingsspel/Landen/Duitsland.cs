using Inlevingsspel.Constants;

namespace Inlevingsspel.Landen
{
    class Duitsland : Land
    {
        public Duitsland(int landID)
        {
            LandID = landID;
            Naam = LandConstants.DuitslandNaam;
            Aandelen[LandID] = 1;
            Groepsnaam = frmselecteren.LandGroep[0];
            Uni = LandConstants.DuitslandUni;
            Fabriekentegoed = LandConstants.DuitslandFabriekenTeGoed;
            Automatiseringtegoed = LandConstants.DuitslandAutomatiseringTeGoed;
            Geld = LandConstants.DuitslandGeld;
            Steenkoolpb = LandConstants.DuitslandSteenkoolPb;
            Ijzerpb = LandConstants.DuitslandIjzerPb;
        }
    }
}
