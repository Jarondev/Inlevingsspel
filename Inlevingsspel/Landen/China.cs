using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    class China : Land
    {
        public China(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = "China";
            Groepsnaam = frmselecteren.LandGroep[2];
            Fabriekentegoed = 4;
            Geld = 300;
            Steenkoolpb = 2;
        }
    }
}
