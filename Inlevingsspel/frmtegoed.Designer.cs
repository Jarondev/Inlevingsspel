namespace Inlevingsspel
{
    partial class frmtegoed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.cbxtegoed = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(12, 86);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(123, 48);
            this.btnsubmit.TabIndex = 0;
            this.btnsubmit.Text = "Bevestig";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(141, 86);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(123, 48);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Annuleren";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // cbxtegoed
            // 
            this.cbxtegoed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxtegoed.FormattingEnabled = true;
            this.cbxtegoed.Location = new System.Drawing.Point(12, 52);
            this.cbxtegoed.Name = "cbxtegoed";
            this.cbxtegoed.Size = new System.Drawing.Size(252, 28);
            this.cbxtegoed.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kies een fabriek voor Duitsland";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmtegoed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxtegoed);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsubmit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmtegoed";
            this.Text = "frmfabriekentegoed";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ComboBox cbxtegoed;
        private System.Windows.Forms.Label label1;
    }
}