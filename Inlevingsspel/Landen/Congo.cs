using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    class Congo : Land
    {
        public Congo(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = "Congo";
            Groepsnaam = frmselecteren.LandGroep[4];
            Geld = 150;
            Waterpb = 4;
            Oliepb = 6;
            Steenkoolpb = 6;
            Ijzerpb = 8;
        }
    }
}
