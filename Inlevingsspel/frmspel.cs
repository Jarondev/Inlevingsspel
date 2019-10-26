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
    public partial class frmspel : Form
    {
        /*
         * 0 = naam
         *  | 1 = duitsland
         *  | 2 = USA
         *  | 3 = china
         *  | 4 = UK
         *  | 5 = congo
         *  | 6 = vietnam
         *  | 7 = nigeria
         *  | 8 = peru
         * 1 = groep
         * 2 = geld
         * 3 = kennis
         * 4 = afval
         * 5 = fabriek
         * 6 = automatisering
         * 7 = school
         * 8 = universiteit
         * 9 = zuiveringsinstallatie
         * 10 = water
         * 11 = olie
         * 12 = steenkool
         * 13 = ijzer
        */
        public static int[,] vs = new int[frmselecteren.LandHoeveelheid,14];
        public static int[,] aandelen = new int[frmselecteren.LandHoeveelheid, frmselecteren.LandHoeveelheid];
        public frmspel()
        {
            InitializeComponent();

        }

        private void frmspel_Shown(object sender, EventArgs e)
        {

        }
    }
}
