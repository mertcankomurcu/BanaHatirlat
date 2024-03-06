using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BanaHatirlat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isStopped = false;
        bool isPanelOn = false;

        private void timer1_Tick(object sender, EventArgs e)
        {
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
        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                // Eğer timer zaten çalışıyorsa, durdur
                timer1.Stop();
                TimerPanel.Stop();
                BtnBaslat.Text = "Başlat"; // Butonun metnini "Başlat" olarak güncelle
                isStopped = true;
            }
            else
            {
                // Eğer timer çalışmıyorsa, başlat
                
                timer1.Interval = int.Parse(TxtSure.Text)*60  * 1000;
                timer1.Start();
                isStopped = false;
                BtnBaslat.Text = "Durdur";
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
            if (this.Size.Width < 320 || this.Size.Height < 178) // Küçük boyut kontrolü
            {
                // Eğer formun boyutu küçükse, daha büyük bir boyuta genişlet
                this.Size = new Size(332, 208); // Örnek olarak genişletilmiş bir boyut
                BtnGenislet.Text = "Küçült";
            }
            else
            {
                // Eğer formun boyutu büyükse, daha küçük bir boyuta küçült
                this.Size = new Size(185, 178); // Örnek olarak küçültülmüş bir boyut
                BtnGenislet.Text = "Genişlet";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string previousValue = Properties.Settings.Default.PreviousValue;
            TxtDosyaYolu.Text = previousValue;
        }

        private void TxtDosyaYolu_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.PreviousValue = TxtDosyaYolu.Text;
            Properties.Settings.Default.Save();
        }
    }
}
