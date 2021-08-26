namespace Sinema_Bilet_Rezervasyon
{
    partial class frmRezervasyon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyon));
            this.pbfilmafis = new System.Windows.Forms.PictureBox();
            this.lblsalonseans = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblkoltuknoayirma = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.txtkoltuknoayirma = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.btnayir = new System.Windows.Forms.Button();
            this.lblkoltuknoiptal = new System.Windows.Forms.Label();
            this.btniptal = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtkoltuknoiptal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btngeri = new System.Windows.Forms.Button();
            this.lblrenk1 = new System.Windows.Forms.Label();
            this.lblrenk2 = new System.Windows.Forms.Label();
            this.lblbos = new System.Windows.Forms.Label();
            this.lbldolu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsaat = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtseans = new System.Windows.Forms.TextBox();
            this.txtsalon = new System.Windows.Forms.TextBox();
            this.txtfilmad = new System.Windows.Forms.TextBox();
            this.lblseans = new System.Windows.Forms.Label();
            this.lblfilmad = new System.Windows.Forms.Label();
            this.lblfilmad2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbperde = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbfilmafis)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbperde)).BeginInit();
            this.SuspendLayout();
            // 
            // pbfilmafis
            // 
            this.pbfilmafis.Location = new System.Drawing.Point(136, 307);
            this.pbfilmafis.Name = "pbfilmafis";
            this.pbfilmafis.Size = new System.Drawing.Size(189, 163);
            this.pbfilmafis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbfilmafis.TabIndex = 75;
            this.pbfilmafis.TabStop = false;
            // 
            // lblsalonseans
            // 
            this.lblsalonseans.AutoSize = true;
            this.lblsalonseans.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsalonseans.ForeColor = System.Drawing.Color.White;
            this.lblsalonseans.Location = new System.Drawing.Point(8, 47);
            this.lblsalonseans.Name = "lblsalonseans";
            this.lblsalonseans.Size = new System.Drawing.Size(37, 16);
            this.lblsalonseans.TabIndex = 70;
            this.lblsalonseans.Text = "Salon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 66;
            this.label3.Text = "C BLOK";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblkoltuknoayirma
            // 
            this.lblkoltuknoayirma.AutoSize = true;
            this.lblkoltuknoayirma.ForeColor = System.Drawing.Color.White;
            this.lblkoltuknoayirma.Location = new System.Drawing.Point(8, 73);
            this.lblkoltuknoayirma.Name = "lblkoltuknoayirma";
            this.lblkoltuknoayirma.Size = new System.Drawing.Size(60, 16);
            this.lblkoltuknoayirma.TabIndex = 33;
            this.lblkoltuknoayirma.Text = "Koltuk No";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.ForeColor = System.Drawing.Color.White;
            this.lblad.Location = new System.Drawing.Point(8, 21);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(23, 16);
            this.lblad.TabIndex = 37;
            this.lblad.Text = "Ad";
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.ForeColor = System.Drawing.Color.White;
            this.lblsoyad.Location = new System.Drawing.Point(8, 46);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(41, 16);
            this.lblsoyad.TabIndex = 39;
            this.lblsoyad.Text = "Soyad";
            // 
            // txtkoltuknoayirma
            // 
            this.txtkoltuknoayirma.Location = new System.Drawing.Point(73, 70);
            this.txtkoltuknoayirma.Name = "txtkoltuknoayirma";
            this.txtkoltuknoayirma.ReadOnly = true;
            this.txtkoltuknoayirma.Size = new System.Drawing.Size(122, 20);
            this.txtkoltuknoayirma.TabIndex = 32;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(74, 19);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(122, 20);
            this.txtad.TabIndex = 36;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(74, 44);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(122, 20);
            this.txtsoyad.TabIndex = 38;
            // 
            // btnayir
            // 
            this.btnayir.BackColor = System.Drawing.Color.White;
            this.btnayir.Location = new System.Drawing.Point(73, 96);
            this.btnayir.Name = "btnayir";
            this.btnayir.Size = new System.Drawing.Size(123, 22);
            this.btnayir.TabIndex = 34;
            this.btnayir.Text = "Bilet Ayırma";
            this.btnayir.UseVisualStyleBackColor = false;
            this.btnayir.Click += new System.EventHandler(this.btnayir_Click);
            // 
            // lblkoltuknoiptal
            // 
            this.lblkoltuknoiptal.AutoSize = true;
            this.lblkoltuknoiptal.ForeColor = System.Drawing.Color.White;
            this.lblkoltuknoiptal.Location = new System.Drawing.Point(7, 18);
            this.lblkoltuknoiptal.Name = "lblkoltuknoiptal";
            this.lblkoltuknoiptal.Size = new System.Drawing.Size(60, 16);
            this.lblkoltuknoiptal.TabIndex = 33;
            this.lblkoltuknoiptal.Text = "Koltuk No";
            // 
            // btniptal
            // 
            this.btniptal.BackColor = System.Drawing.Color.White;
            this.btniptal.Location = new System.Drawing.Point(74, 44);
            this.btniptal.Name = "btniptal";
            this.btniptal.Size = new System.Drawing.Size(122, 23);
            this.btniptal.TabIndex = 35;
            this.btniptal.Text = "Bilet İptali";
            this.btniptal.UseVisualStyleBackColor = false;
            this.btniptal.Click += new System.EventHandler(this.btniptal_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblkoltuknoayirma);
            this.groupBox3.Controls.Add(this.lblad);
            this.groupBox3.Controls.Add(this.txtkoltuknoayirma);
            this.groupBox3.Controls.Add(this.lblsoyad);
            this.groupBox3.Controls.Add(this.txtad);
            this.groupBox3.Controls.Add(this.txtsoyad);
            this.groupBox3.Controls.Add(this.btnayir);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(10, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 136);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BİLET AYIRMA";
            // 
            // txtkoltuknoiptal
            // 
            this.txtkoltuknoiptal.Location = new System.Drawing.Point(74, 19);
            this.txtkoltuknoiptal.Name = "txtkoltuknoiptal";
            this.txtkoltuknoiptal.ReadOnly = true;
            this.txtkoltuknoiptal.Size = new System.Drawing.Size(122, 20);
            this.txtkoltuknoiptal.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "B BLOK";
            // 
            // btngeri
            // 
            this.btngeri.BackColor = System.Drawing.Color.White;
            this.btngeri.Location = new System.Drawing.Point(146, 372);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(64, 23);
            this.btngeri.TabIndex = 48;
            this.btngeri.Text = "Geri Gel";
            this.btngeri.UseVisualStyleBackColor = false;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // lblrenk1
            // 
            this.lblrenk1.BackColor = System.Drawing.Color.Chartreuse;
            this.lblrenk1.Location = new System.Drawing.Point(20, 373);
            this.lblrenk1.Name = "lblrenk1";
            this.lblrenk1.Size = new System.Drawing.Size(20, 20);
            this.lblrenk1.TabIndex = 44;
            // 
            // lblrenk2
            // 
            this.lblrenk2.BackColor = System.Drawing.Color.Red;
            this.lblrenk2.Location = new System.Drawing.Point(81, 373);
            this.lblrenk2.Name = "lblrenk2";
            this.lblrenk2.Size = new System.Drawing.Size(20, 20);
            this.lblrenk2.TabIndex = 45;
            // 
            // lblbos
            // 
            this.lblbos.AutoSize = true;
            this.lblbos.ForeColor = System.Drawing.Color.White;
            this.lblbos.Location = new System.Drawing.Point(42, 375);
            this.lblbos.Name = "lblbos";
            this.lblbos.Size = new System.Drawing.Size(29, 16);
            this.lblbos.TabIndex = 46;
            this.lblbos.Text = "BOŞ";
            // 
            // lbldolu
            // 
            this.lbldolu.AutoSize = true;
            this.lbldolu.ForeColor = System.Drawing.Color.White;
            this.lbldolu.Location = new System.Drawing.Point(104, 375);
            this.lbldolu.Name = "lbldolu";
            this.lbldolu.Size = new System.Drawing.Size(36, 16);
            this.lbldolu.TabIndex = 47;
            this.lbldolu.Text = "DOLU";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblkoltuknoiptal);
            this.groupBox2.Controls.Add(this.btniptal);
            this.groupBox2.Controls.Add(this.txtkoltuknoiptal);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(10, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 82);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BİLET İPTALİ";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(53, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 253);
            this.panel1.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsaat);
            this.groupBox1.Controls.Add(this.lbltarih);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btngeri);
            this.groupBox1.Controls.Add(this.lblrenk1);
            this.groupBox1.Controls.Add(this.lblrenk2);
            this.groupBox1.Controls.Add(this.lblbos);
            this.groupBox1.Controls.Add(this.lbldolu);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(440, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 464);
            this.groupBox1.TabIndex = 69;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REZERVASYON İŞLEMLERİ";
            // 
            // lblsaat
            // 
            this.lblsaat.AutoSize = true;
            this.lblsaat.ForeColor = System.Drawing.Color.White;
            this.lblsaat.Location = new System.Drawing.Point(49, 407);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(0, 16);
            this.lblsaat.TabIndex = 53;
            // 
            // lbltarih
            // 
            this.lbltarih.AutoSize = true;
            this.lbltarih.ForeColor = System.Drawing.Color.White;
            this.lbltarih.Location = new System.Drawing.Point(90, 428);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(0, 16);
            this.lbltarih.TabIndex = 52;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtseans);
            this.groupBox4.Controls.Add(this.txtsalon);
            this.groupBox4.Controls.Add(this.txtfilmad);
            this.groupBox4.Controls.Add(this.lblseans);
            this.groupBox4.Controls.Add(this.lblfilmad);
            this.groupBox4.Controls.Add(this.lblsalonseans);
            this.groupBox4.Location = new System.Drawing.Point(10, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 108);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "FİLM BİLGİLERİ";
            // 
            // txtseans
            // 
            this.txtseans.Location = new System.Drawing.Point(73, 69);
            this.txtseans.Name = "txtseans";
            this.txtseans.ReadOnly = true;
            this.txtseans.Size = new System.Drawing.Size(122, 20);
            this.txtseans.TabIndex = 79;
            // 
            // txtsalon
            // 
            this.txtsalon.Location = new System.Drawing.Point(73, 44);
            this.txtsalon.Name = "txtsalon";
            this.txtsalon.ReadOnly = true;
            this.txtsalon.Size = new System.Drawing.Size(122, 20);
            this.txtsalon.TabIndex = 78;
            // 
            // txtfilmad
            // 
            this.txtfilmad.Location = new System.Drawing.Point(73, 18);
            this.txtfilmad.Name = "txtfilmad";
            this.txtfilmad.ReadOnly = true;
            this.txtfilmad.Size = new System.Drawing.Size(122, 20);
            this.txtfilmad.TabIndex = 77;
            // 
            // lblseans
            // 
            this.lblseans.AutoSize = true;
            this.lblseans.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblseans.ForeColor = System.Drawing.Color.White;
            this.lblseans.Location = new System.Drawing.Point(8, 72);
            this.lblseans.Name = "lblseans";
            this.lblseans.Size = new System.Drawing.Size(39, 16);
            this.lblseans.TabIndex = 76;
            this.lblseans.Text = "Seans";
            // 
            // lblfilmad
            // 
            this.lblfilmad.AutoSize = true;
            this.lblfilmad.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfilmad.ForeColor = System.Drawing.Color.White;
            this.lblfilmad.Location = new System.Drawing.Point(8, 21);
            this.lblfilmad.Name = "lblfilmad";
            this.lblfilmad.Size = new System.Drawing.Size(49, 16);
            this.lblfilmad.TabIndex = 71;
            this.lblfilmad.Text = "Film Adı";
            // 
            // lblfilmad2
            // 
            this.lblfilmad2.AutoSize = true;
            this.lblfilmad2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfilmad2.ForeColor = System.Drawing.Color.White;
            this.lblfilmad2.Location = new System.Drawing.Point(437, 26);
            this.lblfilmad2.Name = "lblfilmad2";
            this.lblfilmad2.Size = new System.Drawing.Size(0, 18);
            this.lblfilmad2.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 68;
            this.label1.Text = "A BLOK";
            // 
            // pbperde
            // 
            this.pbperde.Image = ((System.Drawing.Image)(resources.GetObject("pbperde.Image")));
            this.pbperde.Location = new System.Drawing.Point(33, 12);
            this.pbperde.Name = "pbperde";
            this.pbperde.Size = new System.Drawing.Size(390, 40);
            this.pbperde.TabIndex = 73;
            this.pbperde.TabStop = false;
            // 
            // frmRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(689, 477);
            this.Controls.Add(this.pbfilmafis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblfilmad2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbperde);
            this.Name = "frmRezervasyon";
            this.Text = "Sinema Bilet Rezervasyonu";
            this.Load += new System.EventHandler(this.frmRezervasyon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbfilmafis)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbperde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbfilmafis;
        private System.Windows.Forms.Label lblsalonseans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblkoltuknoayirma;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.TextBox txtkoltuknoayirma;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.Button btnayir;
        private System.Windows.Forms.Label lblkoltuknoiptal;
        private System.Windows.Forms.Button btniptal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtkoltuknoiptal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.Label lblrenk1;
        private System.Windows.Forms.Label lblrenk2;
        private System.Windows.Forms.Label lblbos;
        private System.Windows.Forms.Label lbldolu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblfilmad;
        private System.Windows.Forms.Label lblfilmad2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbperde;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtseans;
        private System.Windows.Forms.TextBox txtsalon;
        private System.Windows.Forms.TextBox txtfilmad;
        private System.Windows.Forms.Label lblseans;
        private System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Label lbltarih;
    }
}