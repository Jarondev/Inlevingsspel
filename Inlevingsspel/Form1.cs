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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnieuw_Click(object sender, EventArgs e)
        {
            frmselecteren frmselectereni = new frmselecteren();
            this.Hide();
            frmselectereni.StartPosition = FormStartPosition.CenterParent;
            frmselectereni.ShowDialog();
            this.Dispose();
        }

        private void btnspelregels_Click(object sender, EventArgs e)
        {
            frmspelregels frmspelregelsi = new frmspelregels();
            frmspelregelsi.StartPosition = FormStartPosition.CenterParent;
            frmspelregelsi.ShowDialog();
        }
    }
}
