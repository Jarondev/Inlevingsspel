namespace Inlevingsspel
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnnieuw = new System.Windows.Forms.Button();
            this.btnladen = new System.Windows.Forms.Button();
            this.btnspelregels = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Het inlevingsspel";
            // 
            // btnnieuw
            // 
            this.btnnieuw.Location = new System.Drawing.Point(12, 64);
            this.btnnieuw.Name = "btnnieuw";
            this.btnnieuw.Size = new System.Drawing.Size(135, 90);
            this.btnnieuw.TabIndex = 1;
            this.btnnieuw.Text = "Nieuw spel starten";
            this.btnnieuw.UseVisualStyleBackColor = true;
            this.btnnieuw.Click += new System.EventHandler(this.btnnieuw_Click);
            // 
            // btnladen
            // 
            this.btnladen.Location = new System.Drawing.Point(12, 160);
            this.btnladen.Name = "btnladen";
            this.btnladen.Size = new System.Drawing.Size(277, 36);
            this.btnladen.TabIndex = 2;
            this.btnladen.Text = "Bestaand spel laden";
            this.btnladen.UseVisualStyleBackColor = true;
            // 
            // btnspelregels
            // 
            this.btnspelregels.Location = new System.Drawing.Point(153, 64);
            this.btnspelregels.Name = "btnspelregels";
            this.btnspelregels.Size = new System.Drawing.Size(135, 90);
            this.btnspelregels.TabIndex = 3;
            this.btnspelregels.Text = "Spelregels";
            this.btnspelregels.UseVisualStyleBackColor = true;
            this.btnspelregels.Click += new System.EventHandler(this.btnspelregels_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 209);
            this.Controls.Add(this.btnspelregels);
            this.Controls.Add(this.btnladen);
            this.Controls.Add(this.btnnieuw);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Het inlevingsspel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnieuw;
        private System.Windows.Forms.Button btnladen;
        private System.Windows.Forms.Button btnspelregels;
    }
}

