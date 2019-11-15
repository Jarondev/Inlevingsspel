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
    public partial class frmoverzicht : Form
    {
        public frmoverzicht()
        {
            InitializeComponent();
        }

        public frmoverzicht(int hoeveelheid)
        {

        }

        private void btnsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
