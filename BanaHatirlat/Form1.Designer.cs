namespace BanaHatirlat
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblVersiyon = new System.Windows.Forms.Label();
            this.TxtSure = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnMuzikSec = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TxtDosyaYolu = new System.Windows.Forms.TextBox();
            this.TimerPanel = new System.Windows.Forms.Timer(this.components);
            this.TxtTekrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGenislet = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.GecenSure = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BasZamani = new System.Windows.Forms.Label();
            this.BitZamani = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.BtnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBaslat.ForeColor = System.Drawing.Color.White;
            this.BtnBaslat.Location = new System.Drawing.Point(250, 99);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(95, 26);
            this.BtnBaslat.TabIndex = 0;
            this.BtnBaslat.Text = "BAŞLA";
            this.BtnBaslat.UseVisualStyleBackColor = false;
            this.BtnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Süre :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.LblVersiyon);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 200);
            this.panel1.TabIndex = 2;
            // 
            // LblVersiyon
            // 
            this.LblVersiyon.AutoSize = true;
            this.LblVersiyon.Location = new System.Drawing.Point(32, 111);
            this.LblVersiyon.Name = "LblVersiyon";
            this.LblVersiyon.Size = new System.Drawing.Size(0, 18);
            this.LblVersiyon.TabIndex = 0;
            // 
            // TxtSure
            // 
            this.TxtSure.Location = new System.Drawing.Point(296, 39);
            this.TxtSure.Name = "TxtSure";
            this.TxtSure.Size = new System.Drawing.Size(49, 24);
            this.TxtSure.TabIndex = 3;
            this.TxtSure.Text = "4";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnMuzikSec
            // 
            this.BtnMuzikSec.Location = new System.Drawing.Point(186, 125);
            this.BtnMuzikSec.Name = "BtnMuzikSec";
            this.BtnMuzikSec.Size = new System.Drawing.Size(35, 32);
            this.BtnMuzikSec.TabIndex = 4;
            this.BtnMuzikSec.UseVisualStyleBackColor = true;
            this.BtnMuzikSec.Click += new System.EventHandler(this.BtnMuzikSec_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TxtDosyaYolu
            // 
            this.TxtDosyaYolu.Enabled = false;
            this.TxtDosyaYolu.Location = new System.Drawing.Point(227, 130);
            this.TxtDosyaYolu.Name = "TxtDosyaYolu";
            this.TxtDosyaYolu.Size = new System.Drawing.Size(141, 24);
            this.TxtDosyaYolu.TabIndex = 0;
            // 
            // TimerPanel
            // 
            this.TimerPanel.Interval = 250;
            this.TimerPanel.Tick += new System.EventHandler(this.TimerPanel_Tick);
            // 
            // TxtTekrar
            // 
            this.TxtTekrar.Location = new System.Drawing.Point(296, 69);
            this.TxtTekrar.Name = "TxtTekrar";
            this.TxtTekrar.Size = new System.Drawing.Size(49, 24);
            this.TxtTekrar.TabIndex = 6;
            this.TxtTekrar.Text = "15";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(229, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tekrar :";
            // 
            // BtnGenislet
            // 
            this.BtnGenislet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.BtnGenislet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGenislet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGenislet.ForeColor = System.Drawing.Color.White;
            this.BtnGenislet.Location = new System.Drawing.Point(80, 2);
            this.BtnGenislet.Name = "BtnGenislet";
            this.BtnGenislet.Size = new System.Drawing.Size(82, 29);
            this.BtnGenislet.TabIndex = 8;
            this.BtnGenislet.Text = "Genişlet";
            this.BtnGenislet.UseVisualStyleBackColor = false;
            this.BtnGenislet.Click += new System.EventHandler(this.BtnGenislet_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(216, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // GecenSure
            // 
            this.GecenSure.AutoSize = true;
            this.GecenSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GecenSure.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GecenSure.Location = new System.Drawing.Point(281, 7);
            this.GecenSure.Name = "GecenSure";
            this.GecenSure.Size = new System.Drawing.Size(0, 24);
            this.GecenSure.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(180, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Başlangıç Zamanı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(216, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bitiş Zamanı :";
            // 
            // BasZamani
            // 
            this.BasZamani.AutoSize = true;
            this.BasZamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BasZamani.Location = new System.Drawing.Point(311, 159);
            this.BasZamani.Name = "BasZamani";
            this.BasZamani.Size = new System.Drawing.Size(0, 18);
            this.BasZamani.TabIndex = 13;
            // 
            // BitZamani
            // 
            this.BitZamani.AutoSize = true;
            this.BitZamani.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BitZamani.Location = new System.Drawing.Point(311, 177);
            this.BitZamani.Name = "BitZamani";
            this.BitZamani.Size = new System.Drawing.Size(0, 18);
            this.BitZamani.TabIndex = 14;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Geçen Süre :";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 221);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(142, 23);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(134)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(180, 199);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BitZamani);
            this.Controls.Add(this.BasZamani);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GecenSure);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnGenislet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTekrar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.TxtDosyaYolu);
            this.Controls.Add(this.BtnMuzikSec);
            this.Controls.Add(this.TxtSure);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBaslat);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bana Hatırlat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtSure;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnMuzikSec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TxtDosyaYolu;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer TimerPanel;
        private System.Windows.Forms.TextBox TxtTekrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGenislet;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label LblVersiyon;
        private System.Windows.Forms.Label GecenSure;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BasZamani;
        private System.Windows.Forms.Label BitZamani;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label3;
    }
}

