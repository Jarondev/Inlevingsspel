﻿using System;
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
        public static int huidig = 0;
        public static int fase = 1;
        public frmspel()
        {
            InitializeComponent();
            for(int i = 0; i <frmselecteren.LandHoeveelheid; i++)
            {
                Landen[i] = new Land();
                for(int j = 0; j < frmselecteren.LandHoeveelheid; j++)
                {
                    Landen[i].Aandelen[j] = 0;
                }
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
                    Landen[i].LandID = i;
                    Landen[i].Aandelen[i] = 1;
                    Landen[i].Naam = "Duitsland";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[0];
                    Landen[i].Uni = 1;
                    Landen[i].Kennispb = 2;
                    Landen[i].Fabriekentegoed = 2;
                    Landen[i].Automatiseringtegoed = 1;
                    Landen[i].Geld = 200;
                    Landen[i].Steenkoolpb = 1;
                    Landen[i].Ijzerpb = 1;
                }
                else if (frmselecteren.isLand[1])
                {
                    frmselecteren.isLand[1] = false;
                    Landen[i].LandID = i;
                    Landen[i].Aandelen[i] = 1;
                    Landen[i].Naam = "USA";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[1];
                    Landen[i].Uni = 1;
                    Landen[i].Kennispb = 2;
                    Landen[i].Fabriekentegoed = 3;
                    Landen[i].Geld = 400;
                    Landen[i].Waterpb = 1;
                    Landen[i].Oliepb = 1;
                    Landen[i].Ijzerpb = 1;
                }
                else if (frmselecteren.isLand[2])
                {
                    frmselecteren.isLand[2] = false;
                    Landen[i].LandID = i;
                    Landen[i].Aandelen[i] = 1;
                    Landen[i].Naam = "China";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[2];
                    Landen[i].Fabriekentegoed = 4;
                    Landen[i].Geld = 300;
                    Landen[i].Steenkoolpb = 2;
                }
                else if (frmselecteren.isLand[3])
                {
                    frmselecteren.isLand[3] = false;
                    Landen[i].LandID = i;
                    Landen[i].Aandelen[i] = 1;
                    Landen[i].Naam = "UK";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[3];
                    Landen[i].Uni = 1;
                    Landen[i].Kennispb = 2;
                    Landen[i].Fabriekentegoed = 2;
                    Landen[i].Geld = 200;
                    Landen[i].Steenkoolpb = 1;
                }
                else if (frmselecteren.isLand[4])
                {
                    frmselecteren.isLand[4] = false;
                    Landen[i].LandID = i;
                    Landen[i].Aandelen[i] = 1;
                    Landen[i].Naam = "Congo";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[4];
                    Landen[i].Geld = 150;
                    Landen[i].Waterpb = 4;
                    Landen[i].Oliepb = 6;
                    Landen[i].Steenkoolpb = 6;
                    Landen[i].Ijzerpb = 8;
                }
                else if (frmselecteren.isLand[5])
                {
                    frmselecteren.isLand[5] = false;
                    Landen[i].LandID = i;
                    Landen[i].Aandelen[i] = 1;
                    Landen[i].Naam = "Vietnam";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[5];
                    Landen[i].Geld = 150;
                    Landen[i].Waterpb = 2;
                    Landen[i].Oliepb = 1;
                    Landen[i].Steenkoolpb = 2;
                    Landen[i].Ijzerpb = 1;
                }
                else if (frmselecteren.isLand[6])
                {
                    frmselecteren.isLand[6] = false;
                    Landen[i].LandID = i;
                    Landen[i].Aandelen[i] = 1;
                    Landen[i].Naam = "Nigeria";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[6];
                    Landen[i].Geld = 100;
                    Landen[i].Waterpb = 2;
                    Landen[i].Oliepb = 8;
                    Landen[i].Steenkoolpb = 2;
                    Landen[i].Ijzerpb = 2;
                }
                else if (frmselecteren.isLand[7])
                {
                    frmselecteren.isLand[7] = false;
                    Landen[i].LandID = i;
                    Landen[i].Aandelen[i] = 1;
                    Landen[i].Naam = "Peru";
                    Landen[i].Groepsnaam = frmselecteren.LandGroep[7];
                    Landen[i].Geld = 100;
                    Landen[i].Waterpb = 1;
                    Landen[i].Oliepb = 1;
                    Landen[i].Steenkoolpb = 4;
                    Landen[i].Ijzerpb = 6;
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
            lblwater.Text = Landen[huidig].Water.ToString();
            lblolie.Text = Landen[huidig].Olie.ToString();
            lblsteenkool.Text = Landen[huidig].Steenkool.ToString();
            lblijzer.Text = Landen[huidig].Ijzer.ToString();
            if (Landen[huidig].Fabrieki.Water) lblwaterfabriek.Text = "Ja";
            else lblwaterfabriek.Text = "Nee";
            if (Landen[huidig].Fabrieki.Ijzer) lblijzerfabriek.Text = "Ja";
            else lblijzerfabriek.Text = "Nee";
            if (Landen[huidig].Fabrieki.Steenkool) lblsteenkoolfabriek.Text = "Ja";
            else lblsteenkoolfabriek.Text = "Nee";
            if (Landen[huidig].Fabrieki.Olie) lbloliefabriek.Text = "Ja";
            else lbloliefabriek.Text = "Nee";
            if (Landen[huidig].Automatiseringi.Water) lblwaterauto.Text = "Ja";
            else lblwaterauto.Text = "Nee";
            if (Landen[huidig].Automatiseringi.Ijzer) lblijzerauto.Text = "Ja";
            else lblijzerauto.Text = "Nee";
            if (Landen[huidig].Automatiseringi.Steenkool) lblsteenkoolauto.Text = "Ja";
            else lblsteenkoolauto.Text = "Nee";
            if (Landen[huidig].Automatiseringi.Olie) lblolieauto.Text = "Ja";
            else lblolieauto.Text = "Nee";
            if (Landen[huidig].Fabriekentegoed >= 1 && !(Landen[huidig].Fabrieki.Water && Landen[huidig].Fabrieki.Ijzer && Landen[huidig].Fabrieki.Steenkool && Landen[huidig].Fabrieki.Olie))
            {
                lblfabriekentegoed.Visible = true;
                lblfabriekentegoed.Text = "Te goed: " + Landen[huidig].Fabriekentegoed.ToString();
            }
            else lblfabriekentegoed.Visible = false;
            if (Landen[huidig].Automatiseringtegoed >= 1 && !(Landen[huidig].Automatiseringi.Water && Landen[huidig].Automatiseringi.Ijzer && Landen[huidig].Automatiseringi.Steenkool && Landen[huidig].Automatiseringi.Olie))
            {
                lblautotegoed.Text = "Te goed: " + Landen[huidig].Automatiseringtegoed.ToString();
                lblautotegoed.Visible = true;
            }
            else lblautotegoed.Visible = false;
            if(fase == 1)
            {
                fase++;
                frmgrondstoffen frmgrondstoffeni = new frmgrondstoffen();
                frmgrondstoffeni.StartPosition = FormStartPosition.CenterParent;
                frmgrondstoffeni.ShowDialog();
                frmspel_Shown(sender, e);
            }
        }

        private void overzichtLandenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmoverzicht overzicht = new frmoverzicht(frmselecteren.LandHoeveelheid);
            overzicht.Show();
        }

        private void lblfabriekentegoed_Click(object sender, EventArgs e)
        {
            frmtegoed frmtegoedi = new frmtegoed(0);
            frmtegoedi.StartPosition = FormStartPosition.CenterParent;
            frmtegoedi.ShowDialog();
            frmspel_Shown(sender, e);
        }

        private void lblautotegoed_Click(object sender, EventArgs e)
        {
            frmtegoed frmtegoedi = new frmtegoed(1);
            frmtegoedi.StartPosition = FormStartPosition.CenterParent;
            frmtegoedi.ShowDialog();
            frmspel_Shown(sender, e);
        }
    }
    public class Land
    {
        public int LandID { get; set; }
        public string Naam { get; set; } = "";
        public string Groepsnaam { get; set; } = "";
        public int[] Aandelen { get; set; } = new int[frmselecteren.LandHoeveelheid];
        public int Geld { get; set; } = 0;
        public int Geldpb { get; set; } = 0;
        public int Kennis { get; set; } = 0;
        public int Kennispb { get; set; } = 0;
        public int Afval { get; set; } = 0;
        public int Afvalpb { get; set; } = 0;
        public int School { get; set; } = 0;
        public int Uni { get; set; } = 0;
        public int Zuivering { get; set; } = 0;
        public int Water { get; set; } = 0;
        public int Waterpb { get; set; } = 0;
        public int Olie { get; set; } = 0;
        public int Oliepb { get; set; } = 0;
        public int Steenkool { get; set; } = 0;
        public int Steenkoolpb { get; set; } = 0;
        public int Ijzer { get; set; } = 0;
        public int Ijzerpb { get; set; } = 0;

        public Fabriek Fabrieki = new Fabriek();

        public Automatisering Automatiseringi = new Automatisering();

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

    public class Automatisering
    {
        public bool Water { get; set; } = false;
        public bool Ijzer { get; set; } = false;
        public bool Steenkool { get; set; } = false;
        public bool Olie { get; set; } = false;
    }

}
