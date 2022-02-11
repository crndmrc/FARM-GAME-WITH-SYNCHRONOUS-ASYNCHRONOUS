using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            string result = "0";
            BLL.MODELS.kullanici _kullanici = new BLL.MODELS.kullanici();
            _kullanici.kullaniciadi = txt_kullaniciAdi.Text;
            _kullanici.sifre = txt_sifre.Text;
            result = _kullanici.GirisYap();
            if (result=="1")
            {
                Anasayfa fAna = new Anasayfa();
                fAna.kullaniciadi = txt_kullaniciAdi.Text;
                fAna.Show();
                this.Hide();
            }
            else
            {
                DialogResult dresult = MessageBox.Show("Hatalı giriş denemesi! Tekrar denemek ister misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result.ToString() == "Yes")
                {
                    txt_kullaniciAdi.Text = "";
                    txt_sifre.Text = "";
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
