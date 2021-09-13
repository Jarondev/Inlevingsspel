using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    class USA : Land
    {
        public USA(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = "USA";
            Groepsnaam = frmselecteren.LandGroep[1];
            Uni = 1;
            Kennispb = 2;
            Fabriekentegoed = 3;
            Geld = 400;
            Waterpb = 1;
            Oliepb = 1;
            Ijzerpb = 1;
        }
    }
}
