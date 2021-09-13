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
    public partial class frmtegoed : Form
    {
        private int nummer;
        //0 = fabriek; 1 = auto
        public frmtegoed(int nr)
        {
            InitializeComponent();
            nummer = nr;
            if (nr == 0)
            {
                label1.Text = "Kies een fabriek voor " + frmspel.Landen[frmspel.huidig].Naam;
                if (frmspel.Landen[frmspel.huidig].Fabriek.Water == false) cbxtegoed.Items.Add("Water");
                if (frmspel.Landen[frmspel.huidig].Fabriek.Ijzer == false) cbxtegoed.Items.Add("Ijzer");
                if (frmspel.Landen[frmspel.huidig].Fabriek.Steenkool == false) cbxtegoed.Items.Add("Steenkool");
                if (frmspel.Landen[frmspel.huidig].Fabriek.Olie == false) cbxtegoed.Items.Add("Olie");
            }
            else
            {
                label1.Text = "Kies een automatiseringseenheid voor " + frmspel.Landen[frmspel.huidig].Naam;
                if (frmspel.Landen[frmspel.huidig].Automatisering.Water == false) cbxtegoed.Items.Add("Water");
                if (frmspel.Landen[frmspel.huidig].Automatisering.Ijzer == false) cbxtegoed.Items.Add("Ijzer");
                if (frmspel.Landen[frmspel.huidig].Automatisering.Steenkool == false) cbxtegoed.Items.Add("Steenkool");
                if (frmspel.Landen[frmspel.huidig].Automatisering.Olie == false) cbxtegoed.Items.Add("Olie");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (cbxtegoed.SelectedItem == null) MessageBox.Show("Je moet een geldige grondstof aanduiden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (cbxtegoed.SelectedItem.ToString().Equals("Water"))
                {
                    if (nummer == 0) frmspel.Landen[frmspel.huidig].Fabriek.Water = true;
                    else frmspel.Landen[frmspel.huidig].Automatisering.Water = true;
                }
                if (cbxtegoed.SelectedItem.ToString().Equals("Ijzer"))
                {
                    if (nummer == 0) frmspel.Landen[frmspel.huidig].Fabriek.Ijzer = true;
                    else frmspel.Landen[frmspel.huidig].Automatisering.Ijzer = true;
                }
                if (cbxtegoed.SelectedItem.ToString().Equals("Steenkool"))
                {
                    if (nummer == 0) frmspel.Landen[frmspel.huidig].Fabriek.Steenkool = true;
                    else frmspel.Landen[frmspel.huidig].Automatisering.Steenkool = true;
                }
                if (cbxtegoed.SelectedItem.ToString().Equals("Olie"))
                {
                    if (nummer == 0) frmspel.Landen[frmspel.huidig].Fabriek.Olie = true;
                    else frmspel.Landen[frmspel.huidig].Automatisering.Olie = true;
                }
                if (nummer == 0) frmspel.Landen[frmspel.huidig].Fabriekentegoed--;
                else frmspel.Landen[frmspel.huidig].Automatiseringtegoed--;
                this.Close();
            }
        }
    }
}
