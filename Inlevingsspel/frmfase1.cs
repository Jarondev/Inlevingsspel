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
    public partial class frmfase1 : Form
    {
        public frmfase1()
        {
            InitializeComponent();
            label2.Text = "Land: " + frmspel.Landen[frmspel.huidig].Naam;
            lblgoud.Text += frmspel.Landen[frmspel.huidig].Geldpb.ToString();
            lblkennis.Text += frmspel.Landen[frmspel.huidig].Kennispb.ToString();
            lblafval.Text += frmspel.Landen[frmspel.huidig].Afvalpb.ToString();
            lblwater.Text += frmspel.Landen[frmspel.huidig].Waterpb.ToString();
            lblolie.Text += frmspel.Landen[frmspel.huidig].Oliepb.ToString();
            lblsteenkool.Text += frmspel.Landen[frmspel.huidig].Steenkoolpb.ToString();
            lblijzer.Text += frmspel.Landen[frmspel.huidig].Ijzerpb.ToString();
            frmspel.Landen[frmspel.huidig].Geld += frmspel.Landen[frmspel.huidig].Geldpb;
            frmspel.Landen[frmspel.huidig].Kennis += frmspel.Landen[frmspel.huidig].Kennispb;
            frmspel.Landen[frmspel.huidig].Afval += frmspel.Landen[frmspel.huidig].Afvalpb;
            frmspel.Landen[frmspel.huidig].Water += frmspel.Landen[frmspel.huidig].Waterpb;
            frmspel.Landen[frmspel.huidig].Olie += frmspel.Landen[frmspel.huidig].Oliepb;
            frmspel.Landen[frmspel.huidig].Steenkool += frmspel.Landen[frmspel.huidig].Steenkoolpb;
            frmspel.Landen[frmspel.huidig].Ijzer += frmspel.Landen[frmspel.huidig].Ijzerpb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
