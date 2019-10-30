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
                if (TestInput(txtnaam.Text))
                {
                    frmselecteren.naam = txtnaam.Text;
                    this.Dispose();
                } else
                {
                    MessageBox.Show("Je moet een geldige naam ingeven! (Geen cijfers, speciale tekens of spaties)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        bool TestInput(string text)
        {
            bool resultaat = true;
            for(int i = 0; i < text.Length; i++)
            {
                if (Convert.ToChar(text.ToLower().Substring(i, 1)) < 97 || Convert.ToChar(text.ToLower().Substring(i, 1)) > 122) resultaat = false;
            }
            return resultaat;
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
