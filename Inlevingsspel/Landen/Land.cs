using Inlevingsspel.Gebouwen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlevingsspel.Landen
{
    public class Land
    {
        public int LandID { get; set; }
        public string Naam { get; set; }
        public string Groepsnaam { get; set; }
        public int[] Aandelen { get; set; } = new int[frmselecteren.LandHoeveelheid];
        public int Geld { get; set; }
        public int Geldpb { get; set; }
        public int Kennis { get; set; }
        public int Kennispb { get; set; }
        public int Afval { get; set; }
        public int Afvalpb { get; set; }
        public int School { get; set; }
        public int Uni { get; set; }
        public int Zuivering { get; set; }
        public int Water { get; set; }
        public int Waterpb { get; set; }
        public int Olie { get; set; }
        public int Oliepb { get; set; }
        public int Steenkool { get; set; }
        public int Steenkoolpb { get; set; }
        public int Ijzer { get; set; }
        public int Ijzerpb { get; set; }
        public Fabriek Fabriek { get; set; } = new Fabriek();
        public Automatisering Automatisering { get; set; } = new Automatisering();
        public int Fabriekentegoed { get; set; }
        public int Automatiseringtegoed { get; set; }

        public Land()
        {

        }
    }
}

