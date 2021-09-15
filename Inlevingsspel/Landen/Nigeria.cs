using Inlevingsspel.Constants;

namespace Inlevingsspel.Landen
{
    class Nigeria : Land
    {
        public Nigeria(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = LandConstants.NigeriaNaam;
            Groepsnaam = frmselecteren.LandGroep[6];
            Geld = LandConstants.NigeriaGeld;
            Waterpb = LandConstants.NigeriaWaterPb;
            Oliepb = LandConstants.NigeriaOliePb;
            Steenkoolpb = LandConstants.NigeriaSteenkoolPb;
            Ijzerpb = LandConstants.NigeriaIjzerPb;
        }
    }
}
