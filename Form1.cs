using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************************
**			    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSİ
**			    2019-2020 BAHAR DÖNEMİ PROJE ÖDEVİ
**	
**				ÖDEV NUMARASI..........:
**				ÖĞRENCİ ADI............:EMİR ÖNDER DEMİRCAN
**				ÖĞRENCİ NUMARASI.......:b191210450
**              DERSİN ALINDIĞI GRUP...:1-A
****************************************************************************/

namespace b191210450_NDP_PROJE_
{
    public partial class Form1 : Form
    {

        int time = 60; //Zaman için değişken atanıyor.
        int toplamPuan = 0; //Puan için değişken atanıyor.

        IAtik randomAtik; //IAtik interfacesinden rastgele atık alınıyor.

        //Class'tan veri almak için değişken ismi belirleniyor.
        OrganikAtikKutusu organikAtikKutusu = new OrganikAtikKutusu();
        KagitKutusu kagitKutusu = new KagitKutusu();
        CamKutusu camKutusu = new CamKutusu();
        MetalKutusu metalKutusu = new MetalKutusu();


        public Form1()
        {
            InitializeComponent();
            //Process Bar'ların maximum ve minimum değerleri veriliyor.
            organikAtikProgressBar.Minimum = 0;
            organikAtikProgressBar.Maximum = 100;
            kagitProgressBar.Minimum = 0;
            kagitProgressBar.Maximum = 100;
            camProgressBar.Minimum = 0;
            camProgressBar.Maximum = 100;
            metalProgressBar.Minimum = 0;
            metalProgressBar.Maximum = 100;

            //Buton kontrolleri yapılıyor.
            organikAtikButton.Enabled = false;
            kagitButton.Enabled = false;
            camButton.Enabled = false;
            metalButton.Enabled = false;
            organikAtikBosaltButton.Enabled = false;
            kagitBosaltButton.Enabled = false;
            camBosaltButton.Enabled = false;
            metalBosaltButton.Enabled = false;

            //Classtan veri çekiliyor ve değer atanıyor.
            organikAtikKutusu.DoluHacim = 0;
            organikAtikKutusu.DolulukOrani = 0;
            kagitKutusu.DoluHacim = 0;
            kagitKutusu.DolulukOrani = 0;
            camKutusu.DoluHacim = 0;
            camKutusu.DolulukOrani = 0;
            metalKutusu.DoluHacim = 0;
            metalKutusu.DolulukOrani = 0;
        }
        private IAtik getRandomAtik ()
        {
            //Atıklar için liste oluşturuluyor.
            List<IAtik> atikList = new List<IAtik>();
            atikList.Add(new KolaKutusu());
            atikList.Add(new Bardak());
            atikList.Add(new CamSise());
            atikList.Add(new Dergi());
            atikList.Add(new Domates());
            atikList.Add(new Salatalik());
            atikList.Add(new SalcaKutusu());
            atikList.Add(new Gazete());

            //Random atık belirleniyor.
            Random random = new Random();
            int randomIndex = random.Next(atikList.Count);

            //Belirlenen rastgele resim Picture Box'a yansıtılıyor.
            atikPictureBox.Image = atikList[randomIndex].Image;

            return atikList[randomIndex];    
        }

        private void yeniOyunButton_Click(object sender, EventArgs e)
        {
            randomAtik = getRandomAtik();
            oyunSuresiTimer.Start(); //Butona tıklanınca Timer başlatılıyor.

            //Buton kontrolleri yapılıyor.
            yeniOyunButton.Enabled = false;
            organikAtikButton.Enabled = true;
            kagitButton.Enabled = true;
            camButton.Enabled = true;
            metalButton.Enabled = true;
            organikAtikBosaltButton.Enabled = true;
            kagitBosaltButton.Enabled = true;
            camBosaltButton.Enabled = true;
            metalBosaltButton.Enabled = true;

            //List Box temizleniyor.
            organikAtikListBox.Items.Clear();
            kagitListBox.Items.Clear();
            camListBox.Items.Clear();
            metalListBox.Items.Clear();

            //Değerler eski haline döndürülüyor.
            organikAtikKutusu.DoluHacim = 0;
            organikAtikKutusu.DolulukOrani = 0;
            kagitKutusu.DoluHacim = 0;
            kagitKutusu.DolulukOrani = 0;
            camKutusu.DoluHacim = 0;
            camKutusu.DolulukOrani = 0;
            metalKutusu.DoluHacim = 0;
            metalKutusu.DolulukOrani = 0;
            organikAtikProgressBar.Value = 0;
            kagitProgressBar.Value = 0;
            camProgressBar.Value = 0;
            metalProgressBar.Value = 0;
            toplamPuan = 0;
            puanMiktarLabel.Text = Convert.ToString(toplamPuan);

        }

        //Class'tan alınan veriler ve hesaplamalar ile atıklar ve hangi kutuya ait oldukları belirleniyor.
        //Atıklar List Box'lara yazdırılıyor.
        //Hacim oranları kadar Process Bar'lar dolduruluyor. 

        private void organikAtikButton_Click(object sender, EventArgs e)
        {
            bool isEklendi = organikAtikKutusu.Ekle(randomAtik);

            if (isEklendi)
            {
                organikAtikListBox.Items.Add(randomAtik.AtikTipi + " " + Convert.ToInt32(randomAtik.Hacim));
                organikAtikProgressBar.Value = organikAtikKutusu.DolulukOrani;
                randomAtik = getRandomAtik();
            }

        }

        private void kagitButton_Click(object sender, EventArgs e)
        {
            bool isEklendi = kagitKutusu.Ekle(randomAtik);

            if (isEklendi)
            {
                kagitListBox.Items.Add(randomAtik.AtikTipi + " " + Convert.ToInt32(randomAtik.Hacim));
                kagitProgressBar.Value = kagitKutusu.DolulukOrani;
                randomAtik = getRandomAtik();
            }

        }

        private void camButton_Click(object sender, EventArgs e)
        {
            bool isEklendi = camKutusu.Ekle(randomAtik);

            if (isEklendi)
            {
                camListBox.Items.Add(randomAtik.AtikTipi + " " + Convert.ToInt32(randomAtik.Hacim));
                camProgressBar.Value = camKutusu.DolulukOrani;
                randomAtik = getRandomAtik();
            }


        }

        private void metalButton_Click(object sender, EventArgs e)
        {
            bool isEklendi = metalKutusu.Ekle(randomAtik);

            if (isEklendi)
            {
                metalListBox.Items.Add(randomAtik.AtikTipi + " " + Convert.ToInt32(randomAtik.Hacim));
                metalProgressBar.Value = metalKutusu.DolulukOrani;
                randomAtik = getRandomAtik();
            }


        }

        //Boşaltma Button'ları ile atıklar boşaltılıyor.
        //Zamana 3 saniye ekleniyor.
        //List Box ve Process Bar'lar temizleniyor.
        //Label'a puanlar yazdırılıyor.

        private void organikAtikBosaltButton_Click(object sender, EventArgs e)
        {
            
            if (organikAtikKutusu.Bosalt())
            {
                toplamPuan += organikAtikKutusu.BosaltmaPuani;
                organikAtikButton.Enabled = false;
                time += 3;
                organikAtikListBox.Items.Clear();
                organikAtikProgressBar.Value = 0;
                organikAtikButton.Enabled = true;
                puanMiktarLabel.Text = Convert.ToString(toplamPuan);
            }

        }

        private void kagitBosaltButton_Click(object sender, EventArgs e)
        {
            if (kagitKutusu.Bosalt())
            {
                toplamPuan += kagitKutusu.BosaltmaPuani;
                kagitButton.Enabled = false;
                time += 3;
                kagitListBox.Items.Clear();
                kagitProgressBar.Value = 0;
                kagitButton.Enabled = true;
                puanMiktarLabel.Text = Convert.ToString(toplamPuan);
            }
        }

        private void camBosaltButton_Click(object sender, EventArgs e)
        {
            if (camKutusu.Bosalt())
            {
                toplamPuan += camKutusu.BosaltmaPuani;
                camButton.Enabled = false;
                time += 3;
                camListBox.Items.Clear();
                camProgressBar.Value = 0;
                camButton.Enabled = true;
                puanMiktarLabel.Text = Convert.ToString(toplamPuan);
            }
        }

        private void metalBosaltButton_Click(object sender, EventArgs e)
        {
            if (metalKutusu.Bosalt())
            {
                toplamPuan += metalKutusu.BosaltmaPuani;
                metalButton.Enabled = false;
                time += 3;
                metalListBox.Items.Clear();
                metalProgressBar.Value = 0;
                metalButton.Enabled = true;
                puanMiktarLabel.Text = Convert.ToString(toplamPuan);
            }
        }

        //Timer ile oyun zamanı kontrol edilip zaman bitince neler olacağı yaptırılıyor.

        private void oyunSuresiTimer_Tick(object sender, EventArgs e)
        {
            time--;
            zamanLabel.Text = time.ToString();
            if (time == 0)
            {
                oyunSuresiTimer.Stop();
                yeniOyunButton.Enabled = true;
                organikAtikButton.Enabled = false;
                kagitButton.Enabled = false;
                camButton.Enabled = false;
                metalButton.Enabled = false;
                organikAtikBosaltButton.Enabled = false;
                kagitBosaltButton.Enabled = false;
                camBosaltButton.Enabled = false;
                metalBosaltButton.Enabled = false;
                time = 60;
                
            }
        }

        //Çıkış Button ile program kapatılıyor.

        private void cikisButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}