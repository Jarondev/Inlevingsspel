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
            lbllijn5.Size = lineSize;
            lbllijn6.Size = lineSize;

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

                Label lblLandAfval = new Label()
                {
                    Text = land.Afval.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 138)
                };

                Label lblLandUni = new Label()
                {
                    Text = land.Uni.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 216)
                };

                ComboBox cbxLandFabriek = new ComboBox()
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Width = 80,
                    Dock = DockStyle.None,
                    Location = new Point(180 + (85 * i), 255)
                };

                FillFabriekenComboBox(cbxLandFabriek, land.Fabriek);

                ComboBox cbxLandAutomatisering = new ComboBox()
                {
                    DropDownStyle = ComboBoxStyle.DropDownList,
                    Width = 80,
                    Dock = DockStyle.None,
                    Location = new Point(180 + (85 * i), 294)
                };

                FillAutomatiseringComboBox(cbxLandAutomatisering, land.Automatisering);

                Label lblLandWater = new Label()
                {
                    Text = land.Water.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 364)
                };

                Label lblLandOlie = new Label()
                {
                    Text = land.Olie.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 403)
                };

                Label lblLandSteenkool = new Label()
                {
                    Text = land.Steenkool.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 442)
                };

                Label lblLandIjzer = new Label()
                {
                    Text = land.Ijzer.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 481)
                };

                Label lblLandWaterPb = new Label()
                {
                    Text = land.Waterpb.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 556)
                };

                Label lblLandOliePb = new Label()
                {
                    Text = land.Oliepb.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 595)
                };

                Label lblLandSteenkoolPb = new Label()
                {
                    Text = land.Steenkoolpb.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 634)
                };

                Label lblLandIjzerPb = new Label()
                {
                    Text = land.Ijzerpb.ToString(),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.None,
                    Location = new Point(165 + (85 * i), 673)
                };

                Controls.Add(lblLandNaam);
                Controls.Add(lblLandGeld);
                Controls.Add(lblLandAfval);
                Controls.Add(lblLandUni);
                Controls.Add(cbxLandFabriek);
                Controls.Add(cbxLandAutomatisering);
                Controls.Add(lblLandWater);
                Controls.Add(lblLandOlie);
                Controls.Add(lblLandSteenkool);
                Controls.Add(lblLandIjzer);
                Controls.Add(lblLandWaterPb);
                Controls.Add(lblLandOliePb);
                Controls.Add(lblLandSteenkoolPb);
                Controls.Add(lblLandIjzerPb);
            }
        }

        private static void FillFabriekenComboBox(ComboBox cbx, Fabriek fabriek)
        {
            if (fabriek.Water) cbx.Items.Add("Water");
            if (fabriek.Olie) cbx.Items.Add("Olie");
            if (fabriek.Steenkool) cbx.Items.Add("Steenkool");
            if (fabriek.Ijzer) cbx.Items.Add("Ijzer");

            if (cbx.Items.Count == 0) cbx.Items.Add("Geen");

            cbx.SelectedIndex = 0;
        }

        private static void FillAutomatiseringComboBox(ComboBox cbx, Automatisering auto)
        {
            if (auto.Water) cbx.Items.Add("Water");
            if (auto.Olie) cbx.Items.Add("Olie");
            if (auto.Steenkool) cbx.Items.Add("Steenkool");
            if (auto.Ijzer) cbx.Items.Add("Ijzer");

            if (cbx.Items.Count == 0) cbx.Items.Add("Geen");

            cbx.SelectedIndex = 0;
        }
    }
}
