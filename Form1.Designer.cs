namespace b191210450_NDP_PROJE_
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
            this.atikGruplariLabel = new System.Windows.Forms.Label();
            this.yeniOyunButton = new System.Windows.Forms.Button();
            this.süreLabel = new System.Windows.Forms.Label();
            this.zamanLabel = new System.Windows.Forms.Label();
            this.puanMiktarLabel = new System.Windows.Forms.Label();
            this.puanLabel = new System.Windows.Forms.Label();
            this.cikisButton = new System.Windows.Forms.Button();
            this.organikAtikButton = new System.Windows.Forms.Button();
            this.kagitButton = new System.Windows.Forms.Button();
            this.camButton = new System.Windows.Forms.Button();
            this.metalButton = new System.Windows.Forms.Button();
            this.organikAtikListBox = new System.Windows.Forms.ListBox();
            this.kagitListBox = new System.Windows.Forms.ListBox();
            this.camListBox = new System.Windows.Forms.ListBox();
            this.metalListBox = new System.Windows.Forms.ListBox();
            this.organikAtikProgressBar = new System.Windows.Forms.ProgressBar();
            this.kagitProgressBar = new System.Windows.Forms.ProgressBar();
            this.camProgressBar = new System.Windows.Forms.ProgressBar();
            this.metalProgressBar = new System.Windows.Forms.ProgressBar();
            this.organikAtikBosaltButton = new System.Windows.Forms.Button();
            this.kagitBosaltButton = new System.Windows.Forms.Button();
            this.camBosaltButton = new System.Windows.Forms.Button();
            this.metalBosaltButton = new System.Windows.Forms.Button();
            this.atikPictureBox = new System.Windows.Forms.PictureBox();
            this.oyunSuresiTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.atikPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // atikGruplariLabel
            // 
            this.atikGruplariLabel.BackColor = System.Drawing.Color.Gray;
            this.atikGruplariLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.atikGruplariLabel.Location = new System.Drawing.Point(359, 12);
            this.atikGruplariLabel.Name = "atikGruplariLabel";
            this.atikGruplariLabel.Size = new System.Drawing.Size(403, 37);
            this.atikGruplariLabel.TabIndex = 0;
            this.atikGruplariLabel.Text = "ATIK GRUPLARI";
            this.atikGruplariLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yeniOyunButton
            // 
            this.yeniOyunButton.BackColor = System.Drawing.Color.Green;
            this.yeniOyunButton.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniOyunButton.Location = new System.Drawing.Point(28, 295);
            this.yeniOyunButton.Name = "yeniOyunButton";
            this.yeniOyunButton.Size = new System.Drawing.Size(276, 88);
            this.yeniOyunButton.TabIndex = 8;
            this.yeniOyunButton.Text = "YENİ OYUN";
            this.yeniOyunButton.UseVisualStyleBackColor = false;
            this.yeniOyunButton.Click += new System.EventHandler(this.yeniOyunButton_Click);
            // 
            // süreLabel
            // 
            this.süreLabel.BackColor = System.Drawing.Color.Blue;
            this.süreLabel.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.süreLabel.Location = new System.Drawing.Point(27, 395);
            this.süreLabel.Name = "süreLabel";
            this.süreLabel.Size = new System.Drawing.Size(282, 36);
            this.süreLabel.TabIndex = 9;
            this.süreLabel.Text = "SÜRE";
            this.süreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zamanLabel
            // 
            this.zamanLabel.BackColor = System.Drawing.Color.Blue;
            this.zamanLabel.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zamanLabel.Location = new System.Drawing.Point(27, 431);
            this.zamanLabel.Name = "zamanLabel";
            this.zamanLabel.Size = new System.Drawing.Size(282, 87);
            this.zamanLabel.TabIndex = 10;
            this.zamanLabel.Text = "60";
            this.zamanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puanMiktarLabel
            // 
            this.puanMiktarLabel.BackColor = System.Drawing.Color.Blue;
            this.puanMiktarLabel.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanMiktarLabel.Location = new System.Drawing.Point(27, 569);
            this.puanMiktarLabel.Name = "puanMiktarLabel";
            this.puanMiktarLabel.Size = new System.Drawing.Size(282, 87);
            this.puanMiktarLabel.TabIndex = 12;
            this.puanMiktarLabel.Text = "0";
            this.puanMiktarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // puanLabel
            // 
            this.puanLabel.BackColor = System.Drawing.Color.Blue;
            this.puanLabel.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLabel.Location = new System.Drawing.Point(27, 533);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(282, 36);
            this.puanLabel.TabIndex = 11;
            this.puanLabel.Text = "PUAN";
            this.puanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cikisButton
            // 
            this.cikisButton.BackColor = System.Drawing.Color.Green;
            this.cikisButton.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButton.Location = new System.Drawing.Point(28, 677);
            this.cikisButton.Name = "cikisButton";
            this.cikisButton.Size = new System.Drawing.Size(276, 88);
            this.cikisButton.TabIndex = 13;
            this.cikisButton.Text = "ÇIKIŞ";
            this.cikisButton.UseVisualStyleBackColor = false;
            this.cikisButton.Click += new System.EventHandler(this.cikisButton_Click);
            // 
            // organikAtikButton
            // 
            this.organikAtikButton.BackColor = System.Drawing.Color.Green;
            this.organikAtikButton.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.organikAtikButton.Location = new System.Drawing.Point(359, 52);
            this.organikAtikButton.Name = "organikAtikButton";
            this.organikAtikButton.Size = new System.Drawing.Size(191, 44);
            this.organikAtikButton.TabIndex = 14;
            this.organikAtikButton.Text = "ORGANİK ATIK";
            this.organikAtikButton.UseVisualStyleBackColor = false;
            this.organikAtikButton.Click += new System.EventHandler(this.organikAtikButton_Click);
            // 
            // kagitButton
            // 
            this.kagitButton.BackColor = System.Drawing.Color.Green;
            this.kagitButton.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kagitButton.Location = new System.Drawing.Point(571, 52);
            this.kagitButton.Name = "kagitButton";
            this.kagitButton.Size = new System.Drawing.Size(191, 44);
            this.kagitButton.TabIndex = 15;
            this.kagitButton.Text = "KAĞIT";
            this.kagitButton.UseVisualStyleBackColor = false;
            this.kagitButton.Click += new System.EventHandler(this.kagitButton_Click);
            // 
            // camButton
            // 
            this.camButton.BackColor = System.Drawing.Color.Green;
            this.camButton.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.camButton.Location = new System.Drawing.Point(359, 411);
            this.camButton.Name = "camButton";
            this.camButton.Size = new System.Drawing.Size(191, 44);
            this.camButton.TabIndex = 16;
            this.camButton.Text = "CAM";
            this.camButton.UseVisualStyleBackColor = false;
            this.camButton.Click += new System.EventHandler(this.camButton_Click);
            // 
            // metalButton
            // 
            this.metalButton.BackColor = System.Drawing.Color.Green;
            this.metalButton.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metalButton.Location = new System.Drawing.Point(570, 411);
            this.metalButton.Name = "metalButton";
            this.metalButton.Size = new System.Drawing.Size(191, 44);
            this.metalButton.TabIndex = 17;
            this.metalButton.Text = "METAL";
            this.metalButton.UseVisualStyleBackColor = false;
            this.metalButton.Click += new System.EventHandler(this.metalButton_Click);
            // 
            // organikAtikListBox
            // 
            this.organikAtikListBox.BackColor = System.Drawing.Color.DarkGray;
            this.organikAtikListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.organikAtikListBox.FormattingEnabled = true;
            this.organikAtikListBox.ItemHeight = 16;
            this.organikAtikListBox.Location = new System.Drawing.Point(359, 102);
            this.organikAtikListBox.Name = "organikAtikListBox";
            this.organikAtikListBox.Size = new System.Drawing.Size(191, 212);
            this.organikAtikListBox.TabIndex = 18;
            // 
            // kagitListBox
            // 
            this.kagitListBox.BackColor = System.Drawing.Color.DarkGray;
            this.kagitListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kagitListBox.FormattingEnabled = true;
            this.kagitListBox.ItemHeight = 16;
            this.kagitListBox.Location = new System.Drawing.Point(570, 102);
            this.kagitListBox.Name = "kagitListBox";
            this.kagitListBox.Size = new System.Drawing.Size(191, 212);
            this.kagitListBox.TabIndex = 19;
            // 
            // camListBox
            // 
            this.camListBox.BackColor = System.Drawing.Color.DarkGray;
            this.camListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.camListBox.FormattingEnabled = true;
            this.camListBox.ItemHeight = 16;
            this.camListBox.Location = new System.Drawing.Point(359, 462);
            this.camListBox.Name = "camListBox";
            this.camListBox.Size = new System.Drawing.Size(191, 212);
            this.camListBox.TabIndex = 20;
            // 
            // metalListBox
            // 
            this.metalListBox.BackColor = System.Drawing.Color.DarkGray;
            this.metalListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metalListBox.FormattingEnabled = true;
            this.metalListBox.ItemHeight = 16;
            this.metalListBox.Location = new System.Drawing.Point(571, 461);
            this.metalListBox.Name = "metalListBox";
            this.metalListBox.Size = new System.Drawing.Size(191, 212);
            this.metalListBox.TabIndex = 21;
            // 
            // organikAtikProgressBar
            // 
            this.organikAtikProgressBar.Location = new System.Drawing.Point(359, 320);
            this.organikAtikProgressBar.Maximum = 700;
            this.organikAtikProgressBar.Name = "organikAtikProgressBar";
            this.organikAtikProgressBar.Size = new System.Drawing.Size(191, 35);
            this.organikAtikProgressBar.TabIndex = 22;
            // 
            // kagitProgressBar
            // 
            this.kagitProgressBar.Location = new System.Drawing.Point(571, 320);
            this.kagitProgressBar.Maximum = 1200;
            this.kagitProgressBar.Name = "kagitProgressBar";
            this.kagitProgressBar.Size = new System.Drawing.Size(191, 35);
            this.kagitProgressBar.TabIndex = 23;
            // 
            // camProgressBar
            // 
            this.camProgressBar.Location = new System.Drawing.Point(359, 680);
            this.camProgressBar.Maximum = 2200;
            this.camProgressBar.Name = "camProgressBar";
            this.camProgressBar.Size = new System.Drawing.Size(191, 35);
            this.camProgressBar.TabIndex = 24;
            // 
            // metalProgressBar
            // 
            this.metalProgressBar.Location = new System.Drawing.Point(571, 680);
            this.metalProgressBar.Maximum = 2300;
            this.metalProgressBar.Name = "metalProgressBar";
            this.metalProgressBar.Size = new System.Drawing.Size(191, 35);
            this.metalProgressBar.TabIndex = 25;
            // 
            // organikAtikBosaltButton
            // 
            this.organikAtikBosaltButton.BackColor = System.Drawing.Color.Green;
            this.organikAtikBosaltButton.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.organikAtikBosaltButton.Location = new System.Drawing.Point(359, 361);
            this.organikAtikBosaltButton.Name = "organikAtikBosaltButton";
            this.organikAtikBosaltButton.Size = new System.Drawing.Size(191, 44);
            this.organikAtikBosaltButton.TabIndex = 26;
            this.organikAtikBosaltButton.Text = "BOŞALT";
            this.organikAtikBosaltButton.UseVisualStyleBackColor = false;
            this.organikAtikBosaltButton.Click += new System.EventHandler(this.organikAtikBosaltButton_Click);
            // 
            // kagitBosaltButton
            // 
            this.kagitBosaltButton.BackColor = System.Drawing.Color.Green;
            this.kagitBosaltButton.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kagitBosaltButton.Location = new System.Drawing.Point(570, 361);
            this.kagitBosaltButton.Name = "kagitBosaltButton";
            this.kagitBosaltButton.Size = new System.Drawing.Size(191, 44);
            this.kagitBosaltButton.TabIndex = 27;
            this.kagitBosaltButton.Text = "BOŞALT";
            this.kagitBosaltButton.UseVisualStyleBackColor = false;
            this.kagitBosaltButton.Click += new System.EventHandler(this.kagitBosaltButton_Click);
            // 
            // camBosaltButton
            // 
            this.camBosaltButton.BackColor = System.Drawing.Color.Green;
            this.camBosaltButton.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.camBosaltButton.Location = new System.Drawing.Point(359, 721);
            this.camBosaltButton.Name = "camBosaltButton";
            this.camBosaltButton.Size = new System.Drawing.Size(191, 44);
            this.camBosaltButton.TabIndex = 28;
            this.camBosaltButton.Text = "BOŞALT";
            this.camBosaltButton.UseVisualStyleBackColor = false;
            this.camBosaltButton.Click += new System.EventHandler(this.camBosaltButton_Click);
            // 
            // metalBosaltButton
            // 
            this.metalBosaltButton.BackColor = System.Drawing.Color.Green;
            this.metalBosaltButton.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.metalBosaltButton.Location = new System.Drawing.Point(570, 721);
            this.metalBosaltButton.Name = "metalBosaltButton";
            this.metalBosaltButton.Size = new System.Drawing.Size(191, 44);
            this.metalBosaltButton.TabIndex = 29;
            this.metalBosaltButton.Text = "BOŞALT";
            this.metalBosaltButton.UseVisualStyleBackColor = false;
            this.metalBosaltButton.Click += new System.EventHandler(this.metalBosaltButton_Click);
            // 
            // atikPictureBox
            // 
            this.atikPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("atikPictureBox.Image")));
            this.atikPictureBox.Location = new System.Drawing.Point(28, 12);
            this.atikPictureBox.Name = "atikPictureBox";
            this.atikPictureBox.Size = new System.Drawing.Size(281, 260);
            this.atikPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atikPictureBox.TabIndex = 30;
            this.atikPictureBox.TabStop = false;
            // 
            // oyunSuresiTimer
            // 
            this.oyunSuresiTimer.Interval = 1000;
            this.oyunSuresiTimer.Tick += new System.EventHandler(this.oyunSuresiTimer_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(768, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 414);
            this.label1.TabIndex = 31;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1100, 813);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.atikPictureBox);
            this.Controls.Add(this.metalBosaltButton);
            this.Controls.Add(this.camBosaltButton);
            this.Controls.Add(this.kagitBosaltButton);
            this.Controls.Add(this.organikAtikBosaltButton);
            this.Controls.Add(this.metalProgressBar);
            this.Controls.Add(this.camProgressBar);
            this.Controls.Add(this.kagitProgressBar);
            this.Controls.Add(this.organikAtikProgressBar);
            this.Controls.Add(this.metalListBox);
            this.Controls.Add(this.camListBox);
            this.Controls.Add(this.kagitListBox);
            this.Controls.Add(this.organikAtikListBox);
            this.Controls.Add(this.metalButton);
            this.Controls.Add(this.camButton);
            this.Controls.Add(this.kagitButton);
            this.Controls.Add(this.organikAtikButton);
            this.Controls.Add(this.cikisButton);
            this.Controls.Add(this.puanMiktarLabel);
            this.Controls.Add(this.puanLabel);
            this.Controls.Add(this.zamanLabel);
            this.Controls.Add(this.süreLabel);
            this.Controls.Add(this.yeniOyunButton);
            this.Controls.Add(this.atikGruplariLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atık Oyunu";
            ((System.ComponentModel.ISupportInitialize)(this.atikPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label atikGruplariLabel;
        private System.Windows.Forms.Button yeniOyunButton;
        private System.Windows.Forms.Label süreLabel;
        private System.Windows.Forms.Label zamanLabel;
        private System.Windows.Forms.Label puanMiktarLabel;
        private System.Windows.Forms.Label puanLabel;
        private System.Windows.Forms.Button cikisButton;
        private System.Windows.Forms.Button organikAtikButton;
        private System.Windows.Forms.Button kagitButton;
        private System.Windows.Forms.Button camButton;
        private System.Windows.Forms.Button metalButton;
        private System.Windows.Forms.ListBox organikAtikListBox;
        private System.Windows.Forms.ListBox kagitListBox;
        private System.Windows.Forms.ListBox camListBox;
        private System.Windows.Forms.ListBox metalListBox;
        private System.Windows.Forms.ProgressBar organikAtikProgressBar;
        private System.Windows.Forms.ProgressBar kagitProgressBar;
        private System.Windows.Forms.ProgressBar camProgressBar;
        private System.Windows.Forms.ProgressBar metalProgressBar;
        private System.Windows.Forms.Button organikAtikBosaltButton;
        private System.Windows.Forms.Button kagitBosaltButton;
        private System.Windows.Forms.Button camBosaltButton;
        private System.Windows.Forms.Button metalBosaltButton;
        private System.Windows.Forms.PictureBox atikPictureBox;
        private System.Windows.Forms.Timer oyunSuresiTimer;
        private System.Windows.Forms.Label label1;
    }
}

