using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inlevingsspel.Landen;

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
            InitialiseerLanden();
        }

        static void InitialiseerLanden()
        {
            for (int i = 0; i < frmselecteren.LandHoeveelheid; i++)
            {
                int landID = Array.IndexOf(frmselecteren.isLand, true);
                switch(landID)
                {
                    case 0:
                        Landen[i] = new Duitsland(i);
                        break;
                    case 1:
                        Landen[i] = new USA(i);
                        break;
                    case 2:
                        Landen[i] = new China(i);
                        break;
                    case 3:
                        Landen[i] = new UK(i);
                        break;
                    case 4:
                        Landen[i] = new Congo(i);
                        break;
                    case 5:
                        Landen[i] = new Vietnam(i);
                        break;
                    case 6:
                        Landen[i] = new Nigeria(i);
                        break;
                    case 7:
                        Landen[i] = new Peru(i);
                        break;
                }
                frmselecteren.isLand[landID] = false;
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

            lblwaterfabriek.Text = Util.BooleanToJaNee(Landen[huidig].Fabriek.Water);
            lblijzerfabriek.Text = Util.BooleanToJaNee(Landen[huidig].Fabriek.Ijzer);
            lblsteenkoolfabriek.Text = Util.BooleanToJaNee(Landen[huidig].Fabriek.Steenkool);
            lbloliefabriek.Text = Util.BooleanToJaNee(Landen[huidig].Fabriek.Olie);
            lblwaterauto.Text = Util.BooleanToJaNee(Landen[huidig].Automatisering.Water);
            lblijzerauto.Text = Util.BooleanToJaNee(Landen[huidig].Automatisering.Ijzer);
            lblsteenkoolauto.Text = Util.BooleanToJaNee(Landen[huidig].Automatisering.Steenkool);
            lblolieauto.Text = Util.BooleanToJaNee(Landen[huidig].Automatisering.Olie);

            if (Landen[huidig].Fabriekentegoed >= 1 
                && !(Landen[huidig].Fabriek.Water 
                && Landen[huidig].Fabriek.Ijzer 
                && Landen[huidig].Fabriek.Steenkool 
                && Landen[huidig].Fabriek.Olie))
            {
                lblfabriekentegoed.Visible = true;
                lblfabriekentegoed.Text = "Te goed: " + Landen[huidig].Fabriekentegoed.ToString();
            }
            else lblfabriekentegoed.Visible = false;
            if (Landen[huidig].Automatiseringtegoed >= 1 
                && !(Landen[huidig].Automatisering.Water 
                && Landen[huidig].Automatisering.Ijzer 
                && Landen[huidig].Automatisering.Steenkool 
                && Landen[huidig].Automatisering.Olie))
            {
                lblautotegoed.Text = "Te goed: " + Landen[huidig].Automatiseringtegoed.ToString();
                lblautotegoed.Visible = true;
            }
            else lblautotegoed.Visible = false;
            switch (fase)
            {
                case 1:
                    fase++;
                    frmfase1 frmgrondstoffeni = new frmfase1();
                    frmgrondstoffeni.StartPosition = FormStartPosition.CenterParent;
                    frmgrondstoffeni.ShowDialog();
                    frmspel_Shown(sender, e);
                    break;
                case 2:
                    fase++;
                    break;
            }
        }

        private void overzichtLandenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmoverzicht overzicht = new frmoverzicht();
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
}
