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
    public partial class frmGiris : Form
    {
        public static string lblbilgi = "";
        public static string lblbilgi2 = "";
        public static string lblbilgi3 = "";
        public frmGiris()
        {
            InitializeComponent();
        }
        private void btnrezerve_Click(object sender, EventArgs e)
        {
            lblbilgi = cbfilm.Text;
            lblbilgi2 = cbsalon.Text;
            lblbilgi3 = cbseans.Text;
            if (cbsalon.SelectedIndex != -1 && cbfilm.SelectedIndex != -1 && cbseans.SelectedIndex != -1)
            {
                frmRezervasyon frmrez = new frmRezervasyon();
                switch (cbfilm.GetItemText(cbfilm.SelectedItem))
                {
                    case "The Godfather":
                        frmrez.pbfilmafis.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"Resimler\" + "god-father.jpg");
                        break;
                    case "Titanic":
                        frmrez.pbfilmafis.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"Resimler\" + "titanic.jpg");
                        break;
                    case "The Silence Of The Lambs":
                        frmrez.pbfilmafis.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"Resimler\" + "the-silence-of.jpg");
                        break;
                    case "Ben-Hur":
                        frmrez.pbfilmafis.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"Resimler\" + "ben-hur.jpg");
                        break;
                    case "Moonlight":
                        frmrez.pbfilmafis.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"Resimler\" + "moonlight.jpg");
                        break;
                }
                frmrez.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Eksiksiz Doldurunuz.");
            }           
        }
    }
}
