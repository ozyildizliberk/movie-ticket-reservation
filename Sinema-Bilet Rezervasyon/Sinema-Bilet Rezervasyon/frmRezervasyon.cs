using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Bilet_Rezervasyon
{
    public partial class frmRezervasyon : Form
    {
        public frmRezervasyon()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void frmRezervasyon_Load(object sender, EventArgs e)
        {
            txtfilmad.Text = frmGiris.lblbilgi.ToString();
            txtsalon.Text = frmGiris.lblbilgi2.ToString();
            txtseans.Text = frmGiris.lblbilgi3.ToString();
            sayac = 1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(35, 35);
                    btn.BackColor = Color.Chartreuse;
                    btn.Location = new Point(j * 35 + 20, i * 35 + 35);
                    btn.Click += btn_Click;
                    btn.Name = sayac.ToString();
                    btn.Text = sayac.ToString();
                    if (j == 4)
                    {
                        continue;
                    }
                    sayac++;
                    this.panel1.Controls.Add(btn);
                    timer1.Start();
                }
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.Chartreuse)
            {
                button.BackColor = Color.Orange;
                txtkoltuknoayirma.Text += button.Text + ",";
            }
            else if (button.BackColor == Color.Red)
            {
                txtkoltuknoiptal.Text += button.Text + ",";
            }
        }
        private void btnayir_Click(object sender, EventArgs e)
        {
            if (txtkoltuknoayirma.Text != ",")
            {
                if (txtkoltuknoayirma.Text != "" && txtad.Text != "" && txtsoyad.Text != "")
                {
                    MessageBox.Show(txtad.Text + " " + txtsoyad.Text + " bilgili kişinin " + txtkoltuknoayirma.Text + " numaralı koltukları ayrılmıştır.");
                    foreach (Control item in panel1.Controls)
                    {
                        if (item is Button)
                        {
                            string[] koltuknumaralariparcala = txtkoltuknoayirma.Text.Split(',');
                            foreach (var no in koltuknumaralariparcala)
                            {
                                if (item.Text == no)
                                {
                                    item.BackColor = Color.Red;
                                }
                            }
                        }
                    }
                    txtkoltuknoayirma.Text = "";
                    txtad.Text = "";
                    txtsoyad.Text = "";
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri eksiksiz doldurunuz.");
                }
            }
            else
            {
                MessageBox.Show("Koltuk numarasını seçmediniz!");
            }
        }
        private void btniptal_Click(object sender, EventArgs e)
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    string[] biletiptalparcala = txtkoltuknoiptal.Text.Split(',');
                    foreach (var no in biletiptalparcala)
                    {
                        if (item.Text == no)
                        {
                            item.BackColor = Color.Chartreuse;
                        }
                    }
                }
            }
            txtkoltuknoiptal.Text = "";
        }
        private void btngeri_Click(object sender, EventArgs e)
        {
            frmGiris frmgeri = new frmGiris();
            frmgeri.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToLongTimeString();
            lblsaat.Text = DateTime.Now.ToLongDateString();
        }
    }
}
