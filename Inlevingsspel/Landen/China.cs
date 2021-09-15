using Inlevingsspel.Constants;

namespace Inlevingsspel.Landen
{
    class China : Land
    {
        public China(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = LandConstants.ChinaNaam;
            Groepsnaam = frmselecteren.LandGroep[2];
            Fabriekentegoed = LandConstants.ChinaFabriekenTeGoed;
            Geld = LandConstants.ChinaGeld;
            Steenkoolpb = LandConstants.ChinaSteenkoolPb;
        }
    }
}
