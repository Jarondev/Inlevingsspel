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
    public partial class frmselecteren : Form
    {
        public frmselecteren()
        {
            InitializeComponent();
        }

        public static Boolean[] isLand = new bool[8];
        public static int LandHoeveelheid = 0;
        public static String[] LandGroep = new string[8];
        public static String naam;

        static void buttonVerwerken(object sender, int land)
        {
            Button button = (Button)sender;
            if (sender.ToString().Contains("Activeren"))
            {
                naam = null;
                GroepLeider groep = new GroepLeider(land);
                groep.StartPosition = FormStartPosition.CenterParent;
                groep.ShowDialog();
                if (naam != null)
                {
                    button.ForeColor = Color.DarkRed;
                    button.Text = "Deactiveren";
                    isLand[land] = true;
                    LandHoeveelheid++;
                    LandGroep[land] = naam;
                }
            } else
            {
                button.ForeColor = Color.Green;
                button.Text = "Activeren";
                isLand[land] = false;
                LandHoeveelheid--;
            }
        }

        private void btnduitsland_Click(object sender, EventArgs e)
        {
            buttonVerwerken(sender, 0);
        }

        private void btnusa_Click(object sender, EventArgs e)
        {
            buttonVerwerken(sender, 1);
        }

        private void btnchina_Click(object sender, EventArgs e)
        {
            buttonVerwerken(sender, 2);
        }

        private void btnvk_Click(object sender, EventArgs e)
        {
            buttonVerwerken(sender, 3);
        }

        private void btncongo_Click(object sender, EventArgs e)
        {
            buttonVerwerken(sender, 4);
        }

        private void btnvietnam_Click(object sender, EventArgs e)
        {
            buttonVerwerken(sender, 5);
        }

        private void btnnigeria_Click(object sender, EventArgs e)
        {
            buttonVerwerken(sender, 6);
        }

        private void btnperu_Click(object sender, EventArgs e)
        {
            buttonVerwerken(sender, 7);
        }

        private void btnoverzicht_Click(object sender, EventArgs e)
        {
            frmoverzicht frmoverzicht = new frmoverzicht();
            frmoverzicht.StartPosition = FormStartPosition.CenterParent;
            frmoverzicht.ShowDialog();
        }
    }
}
