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
                if (frmspel.Landen[frmspel.huidig].Fabrieki.Water == false) cbxtegoed.Items.Add("Water");
                if (frmspel.Landen[frmspel.huidig].Fabrieki.Ijzer == false) cbxtegoed.Items.Add("Ijzer");
                if (frmspel.Landen[frmspel.huidig].Fabrieki.Steenkool == false) cbxtegoed.Items.Add("Steenkool");
                if (frmspel.Landen[frmspel.huidig].Fabrieki.Olie == false) cbxtegoed.Items.Add("Olie");
            }
            else
            {
                label1.Text = "Kies een automatiseringseenheid voor " + frmspel.Landen[frmspel.huidig].Naam;
                if (frmspel.Landen[frmspel.huidig].Automatiseringi.Water == false) cbxtegoed.Items.Add("Water");
                if (frmspel.Landen[frmspel.huidig].Automatiseringi.Ijzer == false) cbxtegoed.Items.Add("Ijzer");
                if (frmspel.Landen[frmspel.huidig].Automatiseringi.Steenkool == false) cbxtegoed.Items.Add("Steenkool");
                if (frmspel.Landen[frmspel.huidig].Automatiseringi.Olie == false) cbxtegoed.Items.Add("Olie");
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
                    if (nummer == 0) frmspel.Landen[frmspel.huidig].Fabrieki.Water = true;
                    else frmspel.Landen[frmspel.huidig].Automatiseringi.Water = true;
                }
                if (cbxtegoed.SelectedItem.ToString().Equals("Ijzer"))
                {
                    if (nummer == 0) frmspel.Landen[frmspel.huidig].Fabrieki.Ijzer = true;
                    else frmspel.Landen[frmspel.huidig].Automatiseringi.Ijzer = true;
                }
                if (cbxtegoed.SelectedItem.ToString().Equals("Steenkool"))
                {
                    if (nummer == 0) frmspel.Landen[frmspel.huidig].Fabrieki.Steenkool = true;
                    else frmspel.Landen[frmspel.huidig].Automatiseringi.Steenkool = true;
                }
                if (cbxtegoed.SelectedItem.ToString().Equals("Olie"))
                {
                    if (nummer == 0) frmspel.Landen[frmspel.huidig].Fabrieki.Olie = true;
                    else frmspel.Landen[frmspel.huidig].Automatiseringi.Olie = true;
                }
                if (nummer == 0) frmspel.Landen[frmspel.huidig].Fabriekentegoed--;
                else frmspel.Landen[frmspel.huidig].Automatiseringtegoed--;
                this.Close();
            }
        }
    }
}
