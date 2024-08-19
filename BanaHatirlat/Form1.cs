using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Reflection;

namespace BanaHatirlat
{
    public partial class Form1 : Form
    {
        private DateTime dt;
        private int secondsElapsed;
        private int secondsRemaining; // Geri sayım süresini tutacak sayaç
        private string formName; // Formun adını saklayacak değişken
        bool isStopped = false;
        bool isPanelOn = false;
        public Form1()
        {
            InitializeComponent();
            formName = this.Text; // Başlangıçta formun adı

            // Sayaç başlangıç değeri
            secondsElapsed = 0;

            // Label'ın başlangıç metni
            GecenSure.Text = TimeSpan.FromSeconds(secondsElapsed).ToString(@"hh\:mm\:ss");
        }


        private void BtnBaslat_Click(object sender, EventArgs e)
        {

            dt = DateTime.Now;
            DateTime dtBitis = dt.AddMinutes(Convert.ToDouble(TxtSure.Text));

            if (timer1.Enabled)
            {
                // Eğer timer zaten çalışıyorsa, durdur
                timer1.Stop();
                TimerPanel.Stop();
                BtnBaslat.Text = "Başlat"; // Butonun metnini "Başlat" olarak güncelle
                isStopped = true;
                timer2.Stop();
                timer3.Stop();

            }
            else
            {
                // Eğer timer çalışmıyorsa, başlat

                timer1.Interval = int.Parse(TxtSure.Text) * 60 * 1000;
                timer1.Start();
                isStopped = false;
                BtnBaslat.Text = "Durdur";
                BasZamani.Text = dt.ToString("HH:mm:ss");
                BitZamani.Text = dtBitis.ToString("HH:mm:ss");
                secondsElapsed = 0;
                GecenSure.Text = TimeSpan.FromSeconds(secondsElapsed).ToString(@"hh\:mm\:ss");
                timer2.Start();
                timer3.Start();
                secondsRemaining = int.Parse(TxtSure.Text)*60;
                UpdateTitle();

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Geçen sürenin sayacını artır
            secondsElapsed++;

            // Geçen süreyi label'a yaz
            GecenSure.Text = TimeSpan.FromSeconds(secondsElapsed).ToString(@"hh\:mm\:ss");
            if (!isStopped)
            {
                string musicPath = TxtDosyaYolu.Text;

                // Eğer müzik dosyası yolu belirtilmişse
                if (!string.IsNullOrEmpty(musicPath) && File.Exists(musicPath))
                {
                    // Müziği çal
                    axWindowsMediaPlayer1.URL = musicPath;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    TimerPanel.Start();
                    if (checkBox1.Checked == true)
                    {
                        // Her 15 saniyede bir çalışmasını sağlamak için interval'i güncelle
                        timer1.Stop();
                        timer1.Interval = int.Parse(TxtTekrar.Text) * 1000; // 15 saniye
                        timer1.Start();
                    }
                    else
                    {
                        // Timer durdurulduğunda, tekrar 4 dakika beklemesi için interval'i güncelle
                        timer1.Stop();
                    }
                }
                else
                {
                    MessageBox.Show("Geçerli bir müzik dosyası yolu belirtmelisiniz.");
                }
            }

        }
        private void TimerPanel_Tick(object sender, EventArgs e)
        {
            if (isPanelOn)
            {
                panel1.Visible = false;
                isPanelOn = false;
            }
            else
            {
                panel1.Visible = true;
                isPanelOn = true;
            }
        }

        private void BtnMuzikSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Müzik Seç";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedMusic = openFileDialog1.FileName;
                TxtDosyaYolu.Text = selectedMusic;
            }
        }

        private void BtnGenislet_Click(object sender, EventArgs e)
        {
            if (this.Size.Width < 405 || this.Size.Height < 242) // Küçük boyut kontrolü
            {
                // Eğer formun boyutu küçükse, daha büyük bir boyuta genişlet
                this.Size = new Size(405, 242); // Örnek olarak genişletilmiş bir boyut
                BtnGenislet.Text = "Küçült";
 
            }


            else
            {
                // Eğer formun boyutu büyükse, daha küçük bir boyuta küçült
                this.Size = new Size(200, 242); // Örnek olarak küçültülmüş bir boyut
                BtnGenislet.Text = "Genişlet";
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Geçen sürenin sayacını artır
            secondsElapsed++;

            // Geçen süreyi label'a yaz
            GecenSure.Text = TimeSpan.FromSeconds(secondsElapsed).ToString(@"hh\:mm\:ss");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            // Eğer geri sayım süresi bitmemişse
            if (secondsRemaining > 0)
            {
                secondsRemaining--; // Süreyi bir saniye azalt
                UpdateTitle(); // Başlığı güncelle
            }
            else
            {
                // Geri sayım tamamlandığında timer'ı durdur
                timer3.Stop();
            }
        }
        private void UpdateTitle()
        {
            // Başlığı güncelle
            this.Text = $"{formName} [{TimeSpan.FromSeconds(secondsRemaining).ToString(@"mm\:ss")}]";

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.PreviousValue = TxtDosyaYolu.Text;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string previousValue = Properties.Settings.Default.PreviousValue;
            TxtDosyaYolu.Text = previousValue;
        }
    }
}
