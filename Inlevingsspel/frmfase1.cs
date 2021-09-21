using Inlevingsspel.Landen;
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
        public frmfase1(Land land)
        {
            InitializeComponent();
            label2.Text = "Land: " + land.Naam;
            lblgoud.Text += land.Geldpb.ToString();
            lblkennis.Text += land.Kennispb.ToString();
            lblafval.Text += land.Afvalpb.ToString();
            lblwater.Text += land.Waterpb.ToString();
            lblolie.Text += land.Oliepb.ToString();
            lblsteenkool.Text += land.Steenkoolpb.ToString();
            lblijzer.Text += land.Ijzerpb.ToString();
            land.Geld += land.Geldpb;
            land.Kennis += land.Kennispb;
            land.Afval += land.Afvalpb;
            land.Water += land.Waterpb;
            land.Olie += land.Oliepb;
            land.Steenkool += land.Steenkoolpb;
            land.Ijzer += land.Ijzerpb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
