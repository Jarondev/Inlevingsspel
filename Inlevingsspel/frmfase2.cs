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
        private Land land = null;

        public frmfase2(Land land)
        {
            InitializeComponent();
            this.land = land;
            label2.Text = "Land: " + land.Naam;
            int aandelenCount = 0;
            for(int i = 0; i < land.Aandelen.Length; i++)
            {
                if(land.Aandelen[i] != 0 )
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
                    btnLandAandeel.Click += new EventHandler(button_Click);
                    aandelenCount++;
                    Controls.Add(labelAandeelText);
                    Controls.Add(btnLandAandeel);
                }
            }

        }

        private void button_Click(object sender, EventArgs e)
        {
            int landId = int.Parse(((Button)sender).Name);
            if (land.Aandelen[landId] != 0)
            {

            }
            else MessageBox.Show("Je hebt geen aandelen bij dit land!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
