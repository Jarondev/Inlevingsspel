using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    class Vietnam : Land
    {
        public Vietnam(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = "Vietnam";
            Groepsnaam = frmselecteren.LandGroep[5];
            Geld = 150;
            Waterpb = 2;
            Oliepb = 1;
            Steenkoolpb = 2;
            Ijzerpb = 1;
        }
    }
}
