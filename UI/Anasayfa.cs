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
    public partial class Anasayfa : Form
    {
        //global değişken
        public string kullaniciadi;
        public Anasayfa()
        {
            InitializeComponent();
        }
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            

        }
        private async void btn_inek_Click(object sender, EventArgs e)
        {
            btn_inek.Enabled = false;
            for (int i=10;i>=0;i--)
            {
                //buton içinde geri sayım yapılıyor.
                btn_inek.Text = i.ToString();
                await Task.Run(() => System.Threading.Thread.Sleep(1000));

                if (i == 0)
                {
                    btn_inek.Enabled = true;
                    BLL.MODELS.game _game = new BLL.MODELS.game();

                    int sayi = int.Parse(lbl_inek.Text);
                    lbl_inek.Text = (sayi + 1).ToString();

                    int skor = int.Parse(lbl_skor.Text);

                    lbl_skor.Text = (skor + 5).ToString();
                }
            }
            
        }

        private async void btn_sut_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbl_inek.Text) > 0)
            {
                btn_sut.Enabled = false;
                for (int i = 5; i >= 0; i--)
                {
                    //buton içinde geri sayım yapılıyor.
                    btn_sut.Text = i.ToString();
                    await Task.Run(() => System.Threading.Thread.Sleep(1000));
                    if (i == 0)
                    {
                        btn_sut.Enabled = true;
                        BLL.MODELS.game _game = new BLL.MODELS.game();
                        _game.bekleSut();

                        int sut = int.Parse(lbl_sut.Text);
                        int inek = int.Parse(lbl_inek.Text);
                        int eklenecekSut = (inek * 5);
                        lbl_sut.Text = (sut + eklenecekSut).ToString();

                        int sut1 = int.Parse(lbl_sut.Text);
                        int skor = int.Parse(lbl_skor.Text);
                        int eklenecekPuan = (sut1 * 2);
                        lbl_skor.Text = (skor + eklenecekPuan).ToString();
                    }
                }
            }
            
        }

        public async Task<int> bekleAsync()
        {
            BLL.MODELS.game _game = new BLL.MODELS.game();
            for (int a = 10; a >= 0; a--)
            {
                btn_sut.Text = a.ToString();
                _game.bekleSut().ToString();
            }
            int sure = 1000;
            await Task.Run(() => System.Threading.Thread.Sleep(sure));
            return (sure / 100);
        }

        private void btn_async_Click(object sender, EventArgs e)
        {
            BLL.MODELS.game _game = new BLL.MODELS.game();
            BLL.MODELS.kullanici _kullanici = new BLL.MODELS.kullanici();
            _game.kullaniciadi = kullaniciadi;
            _game.inekSayisi = int.Parse(lbl_inek.Text);
            _game.sutSayisi = int.Parse(lbl_sut.Text);
            _game.skorPuani = int.Parse(lbl_skor.Text);
            _game.Ekle();
        }
    }
}
