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
    public partial class frmgroepleider : Form
    {
        public frmgroepleider(int land)
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtnaam.Text))
            {
                MessageBox.Show("Je moet een geldige naam ingeven!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                frmselecteren.naam = txtnaam.Text;
                this.Dispose();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
