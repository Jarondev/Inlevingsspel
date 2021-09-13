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
            Naam = "Peru";
            Groepsnaam = frmselecteren.LandGroep[7];
            Geld = 100;
            Waterpb = 1;
            Oliepb = 1;
            Steenkoolpb = 4;
            Ijzerpb = 6;
        }
    }
}
