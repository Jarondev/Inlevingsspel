using Inlevingsspel.Landen;
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
    public partial class frmfase2 : Form
    {
        public frmfase2(Land land)
        {
            InitializeComponent();
            label2.Text = "Land: " + land.Naam;
            int aandelenCount = 0;
            for(int i = 0; i < land.Aandelen.Length; i++)
            {
                if(land.Aandelen[i] != 0 && i != land.LandID)
                {
                    Label labelAandeelText = new Label()
                    {
                        Location = new Point(13, 73 + (74 * aandelenCount)),
                        Text = "Aandelen in " + frmspel.Landen[i] + ": " + land.Aandelen[i]
                    };
                    Button btnLandAandeel = new Button()
                    {
                        Location = new Point(17, 100 + (74 * aandelenCount)),
                        Size = new Size(245, 39),
                        Text = "Grondstoffen opeisen",
                        Name = i.ToString()
                    };
                    aandelenCount++;
                }
            }

        }
    }
}
