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
        public static int[][] vs = new int[frmselecteren.LandHoeveelheid][];
        public frmspel()
        {
            InitializeComponent();
        }
    }
}
