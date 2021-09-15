using Inlevingsspel.Constants;

namespace Inlevingsspel.Landen
{
    class Congo : Land
    {
        public Congo(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = LandConstants.CongoNaam;
            Groepsnaam = frmselecteren.LandGroep[4];
            Geld = LandConstants.CongoGeld;
            Waterpb = LandConstants.CongoWaterPb;
            Oliepb = LandConstants.CongoOliePb;
            Steenkoolpb = LandConstants.CongoSteenkoolPb;
            Ijzerpb = LandConstants.CongoIjzerPb;
        }
    }
}
