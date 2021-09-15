using Inlevingsspel.Gebouwen;
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
    public partial class frmoverzicht : Form
    {
        public frmoverzicht()
        {
            InitializeComponent();
            int landenCount = frmspel.Landen.Length;
            ModifyForm(landenCount);
        }

        private void btnsluiten_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void ModifyForm(int landenCount)
        {
            Size lineSize = new Size(20 + (85 * landenCount), lbllijn1.Size.Height);
            lbllijn1.Size = lineSize;
            lbllijn2.Size = lineSize;
            lbllijn3.Size = lineSize;
            lbllijn4.Size = lineSize;

            Width = 85 * (1 + landenCount) + 155;
            btnsluiten.Location = new Point(Width - 185, btnsluiten.Location.Y);

            for (int i = 0; i < landenCount; i++)
            {
                Land land = frmspel.Landen[i];

                Label lblLandNaam = new Label() {
                    Text = land.Naam,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 13),
                    Font = new Font(Font.FontFamily, 12f, FontStyle.Bold)
                };

                Label lblLandGeld = new Label()
                {
                    Text = land.Geld.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 70)
                };

                Label lblLandUni = new Label()
                {
                    Text = land.Uni.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 138)
                };

                Label lblLandFabriek = new Label()
                {
                    Text = "Placeholder",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 177)
                };

                Label lblLandAutomatisering = new Label()
                {
                    Text = "Placeholder",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 216)
                };

                Controls.Add(lblLandNaam);
                Controls.Add(lblLandGeld);
                Controls.Add(lblLandUni);
                Controls.Add(lblLandFabriek);
                Controls.Add(lblLandAutomatisering);
            }
        }
    }
}
