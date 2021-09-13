using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    class UK : Land
    {
        public UK(int landID)
        {
            LandID = landID;
            Aandelen[landID] = 1;
            Naam = "UK";
            Groepsnaam = frmselecteren.LandGroep[3];
            Uni = 1;
            Kennispb = 2;
            Fabriekentegoed = 2;
            Geld = 200;
            Steenkoolpb = 1;
        }
    }
}
