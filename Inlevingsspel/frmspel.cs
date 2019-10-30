using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlevingsspel
{
    public partial class frmspel : Form
    {
        public static Land[] Landen = new Land[frmselecteren.LandHoeveelheid];
        public static int[,] aandelen = new int[frmselecteren.LandHoeveelheid, frmselecteren.LandHoeveelheid];
        public static int huidig = 0;
        public static int fase = 1;
        public frmspel()
        {
            InitializeComponent();
            for(int i = 0; i <frmselecteren.LandHoeveelheid; i++)
            {
                Landen[i] = new Land();
            }
            InitialiseerLanden();
        }

        static void InitialiseerLanden()
        {
            for (int i = 0; i < frmselecteren.LandHoeveelheid; i++)
            {
                if (frmselecteren.isLand[0])
                {
                    frmselecteren.isLand[0] = false;
                    Landen[i].Naam = "Duitsland";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[0];
                    Landen[i].Fabriekentegoed = 2;
                    Landen[i].Automatiseringtegoed = 1;
                    Landen[i].Geld = 200;
                    Landen[i].Steenkool = 1;
                    Landen[i].Ijzer = 1;
                }
                else if (frmselecteren.isLand[1])
                {
                    frmselecteren.isLand[1] = false;
                    Landen[i].Naam = "USA";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[1];
                    Landen[i].Uni = 1;
                    Landen[i].Fabriekentegoed = 3;
                    Landen[i].Geld = 400;
                    Landen[i].Water = 1;
                    Landen[i].Olie = 1;
                    Landen[i].Ijzer = 1;
                }
                else if (frmselecteren.isLand[2])
                {
                    frmselecteren.isLand[2] = false;
                    Landen[i].Naam = "China";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[2];
                    Landen[i].Fabriekentegoed = 4;
                    Landen[i].Geld = 300;
                    Landen[i].Steenkool = 2;
                }
                else if (frmselecteren.isLand[3])
                {
                    frmselecteren.isLand[3] = false;
                    Landen[i].Naam = "UK";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[3];
                    Landen[i].Uni = 1;
                    Landen[i].Fabriekentegoed = 2;
                    Landen[i].Geld = 200;
                    Landen[i].Steenkool = 1;
                }
                else if (frmselecteren.isLand[4])
                {
                    frmselecteren.isLand[4] = false;
                    Landen[i].Naam = "Congo";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[4];
                    Landen[i].Geld = 150;
                    Landen[i].Water = 4;
                    Landen[i].Olie = 6;
                    Landen[i].Steenkool = 6;
                    Landen[i].Ijzer = 8;
                }
                else if (frmselecteren.isLand[5])
                {
                    frmselecteren.isLand[5] = false;
                    Landen[i].Naam = "Vietnam";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[5];
                    Landen[i].Geld = 150;
                    Landen[i].Water = 2;
                    Landen[i].Olie = 1;
                    Landen[i].Steenkool = 2;
                    Landen[i].Ijzer = 1;
                }
                else if (frmselecteren.isLand[6])
                {
                    frmselecteren.isLand[6] = false;
                    Landen[i].Naam = "Nigeria";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[6];
                    Landen[i].Geld = 100;
                    Landen[i].Water = 2;
                    Landen[i].Olie = 8;
                    Landen[i].Steenkool = 2;
                    Landen[i].Ijzer = 2;
                }
                else if (frmselecteren.isLand[7])
                {
                    frmselecteren.isLand[7] = false;
                    Landen[i].Naam = "Peru";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[7];
                    Landen[i].Geld = 100;
                    Landen[i].Water = 1;
                    Landen[i].Olie = 1;
                    Landen[i].Steenkool = 4;
                    Landen[i].Ijzer = 6;
                }
            }
        }
        private void frmspel_Shown(object sender, EventArgs e)
        {
            lblland.Text = "Huidig land: " + Landen[huidig].Naam;
            lblgroep.Text = "Groep van: " + Landen[huidig].Groepsnaam;
            lblgoud.Text = Landen[huidig].Geld.ToString();
            lblkennis.Text = Landen[huidig].Kennis.ToString();
            lblafval.Text = Landen[huidig].Afval.ToString();
            lbluni.Text = Landen[huidig].Uni.ToString();
            lblfabriek.Text = "";
            lblautomatisering.Text = Landen[huidig].Automatiseringtegoed.ToString();
            lblwater.Text = Landen[huidig].Water.ToString();
            lblolie.Text = Landen[huidig].Olie.ToString();
            lblsteenkool.Text = Landen[huidig].Steenkool.ToString();
            lblijzer.Text = Landen[huidig].Ijzer.ToString();
        }
    }
    public class Land
    {
        public string Naam { get; set; } = "";
        public string Groepsnaam { get; set; } = "";
        public int Geld { get; set; } = 0;
        public int Kennis { get; set; } = 0;
        public int Afval { get; set; } = 0;
        public int Auto { get; set; } = 0;
        public int School { get; set; } = 0;
        public int Uni { get; set; } = 0;
        public int Zuivering { get; set; } = 0;
        public int Water { get; set; } = 0;
        public int Olie { get; set; } = 0;
        public int Steenkool { get; set; } = 0;
        public int Ijzer { get; set; } = 0;

        public Fabriek Fabrieki = new Fabriek();
        public int Aandelen { get; set; } = 4;

        public int Fabriekentegoed { get; set; } = 0;

        public int Automatiseringtegoed { get; set; } = 0;
    }

    public class Fabriek
    {
        public bool Water { get; set; } = false;
        public bool Ijzer { get; set; } = false;
        public bool Steenkool { get; set; } = false;
        public bool Olie { get; set; } = false;
    }

}
