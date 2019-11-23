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
            if (nr == 0) label1.Text = "Kies een fabriek voor " + frmspel.Landen[frmspel.huidig].Naam;
            else label1.Text = "Kies een automatiseringseenheid voor " + frmspel.Landen[frmspel.huidig].Naam;
        }
    }
}
