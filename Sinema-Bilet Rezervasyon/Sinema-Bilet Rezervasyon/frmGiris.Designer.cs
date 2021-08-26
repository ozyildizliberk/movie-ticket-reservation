namespace Sinema_Bilet_Rezervasyon
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.cbseans = new System.Windows.Forms.ComboBox();
            this.cbsalon = new System.Windows.Forms.ComboBox();
            this.btnrezerve = new System.Windows.Forms.Button();
            this.cbfilm = new System.Windows.Forms.ComboBox();
            this.lblseans = new System.Windows.Forms.Label();
            this.lblsalon = new System.Windows.Forms.Label();
            this.lblfilm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbseans
            // 
            this.cbseans.FormattingEnabled = true;
            this.cbseans.Items.AddRange(new object[] {
            "14.00",
            "15.00",
            "18.00",
            "19.00",
            "21.00",
            "22.00"});
            this.cbseans.Location = new System.Drawing.Point(157, 153);
            this.cbseans.Name = "cbseans";
            this.cbseans.Size = new System.Drawing.Size(156, 21);
            this.cbseans.TabIndex = 25;
            // 
            // cbsalon
            // 
            this.cbsalon.FormattingEnabled = true;
            this.cbsalon.Items.AddRange(new object[] {
            "Salon-1",
            "Salon-2",
            "Salon-3"});
            this.cbsalon.Location = new System.Drawing.Point(157, 119);
            this.cbsalon.Name = "cbsalon";
            this.cbsalon.Size = new System.Drawing.Size(156, 21);
            this.cbsalon.TabIndex = 24;
            // 
            // btnrezerve
            // 
            this.btnrezerve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.btnrezerve.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrezerve.ForeColor = System.Drawing.Color.White;
            this.btnrezerve.Location = new System.Drawing.Point(327, 101);
            this.btnrezerve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnrezerve.Name = "btnrezerve";
            this.btnrezerve.Size = new System.Drawing.Size(98, 52);
            this.btnrezerve.TabIndex = 23;
            this.btnrezerve.Text = "Rezervasyon Tamamla";
            this.btnrezerve.UseVisualStyleBackColor = false;
            this.btnrezerve.Click += new System.EventHandler(this.btnrezerve_Click);
            // 
            // cbfilm
            // 
            this.cbfilm.FormattingEnabled = true;
            this.cbfilm.Items.AddRange(new object[] {
            "The Godfather",
            "Titanic",
            "The Silence Of The Lambs",
            "Ben-Hur",
            "Moonlight"});
            this.cbfilm.Location = new System.Drawing.Point(157, 87);
            this.cbfilm.Name = "cbfilm";
            this.cbfilm.Size = new System.Drawing.Size(156, 21);
            this.cbfilm.TabIndex = 22;
            // 
            // lblseans
            // 
            this.lblseans.AutoSize = true;
            this.lblseans.BackColor = System.Drawing.Color.Transparent;
            this.lblseans.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblseans.ForeColor = System.Drawing.Color.White;
            this.lblseans.Location = new System.Drawing.Point(68, 155);
            this.lblseans.Name = "lblseans";
            this.lblseans.Size = new System.Drawing.Size(81, 16);
            this.lblseans.TabIndex = 19;
            this.lblseans.Text = "Seans Seçiniz";
            // 
            // lblsalon
            // 
            this.lblsalon.AutoSize = true;
            this.lblsalon.BackColor = System.Drawing.Color.Transparent;
            this.lblsalon.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsalon.ForeColor = System.Drawing.Color.White;
            this.lblsalon.Location = new System.Drawing.Point(68, 121);
            this.lblsalon.Name = "lblsalon";
            this.lblsalon.Size = new System.Drawing.Size(79, 16);
            this.lblsalon.TabIndex = 20;
            this.lblsalon.Text = "Salon Seçiniz";
            // 
            // lblfilm
            // 
            this.lblfilm.AutoSize = true;
            this.lblfilm.BackColor = System.Drawing.Color.Transparent;
            this.lblfilm.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfilm.ForeColor = System.Drawing.Color.White;
            this.lblfilm.Location = new System.Drawing.Point(68, 89);
            this.lblfilm.Name = "lblfilm";
            this.lblfilm.Size = new System.Drawing.Size(71, 16);
            this.lblfilm.TabIndex = 21;
            this.lblfilm.Text = "Film Seçiniz";
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 261);
            this.Controls.Add(this.cbseans);
            this.Controls.Add(this.cbsalon);
            this.Controls.Add(this.btnrezerve);
            this.Controls.Add(this.cbfilm);
            this.Controls.Add(this.lblseans);
            this.Controls.Add(this.lblsalon);
            this.Controls.Add(this.lblfilm);
            this.Name = "frmGiris";
            this.Text = "Sinema Bilet Rezervasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbseans;
        private System.Windows.Forms.ComboBox cbsalon;
        private System.Windows.Forms.Button btnrezerve;
        private System.Windows.Forms.ComboBox cbfilm;
        private System.Windows.Forms.Label lblseans;
        private System.Windows.Forms.Label lblsalon;
        private System.Windows.Forms.Label lblfilm;
    }
}

