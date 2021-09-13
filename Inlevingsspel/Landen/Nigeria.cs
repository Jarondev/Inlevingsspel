using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    class Nigeria : Land
    {
        public Nigeria(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = "Nigeria";
            Groepsnaam = frmselecteren.LandGroep[6];
            Geld = 100;
            Waterpb = 2;
            Oliepb = 8;
            Steenkoolpb = 2;
            Ijzerpb = 2;
        }
    }
}
