using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    class Duitsland : Land
    {
        public Duitsland(int landID)
        {
            LandID = landID;
            Naam = "Duitsland";
            Aandelen[LandID] = 1;
            Groepsnaam = frmselecteren.LandGroep[0];
            Uni = 1;
            Kennispb = 2;
            Fabriekentegoed = 2;
            Automatiseringtegoed = 1;
            Geld = 200;
            Steenkoolpb = 1;
            Ijzerpb = 1;
        }
    }
}
