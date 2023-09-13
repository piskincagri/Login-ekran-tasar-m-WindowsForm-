namespace market
{
    partial class SifreDegistirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistirme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmb_GuvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.txt_GuvenlikCevabi = new System.Windows.Forms.TextBox();
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBox_MailAlani = new System.Windows.Forms.GroupBox();
            this.timerLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_DogrulamaKoduOnayla = new System.Windows.Forms.Button();
            this.btn_DogrulamaKoduGonder = new System.Windows.Forms.Button();
            this.txt_DogrulamaKodu = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBoz_SifreDegistirmeAlani = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SifreDegistir = new System.Windows.Forms.Button();
            this.txt_YeniSifreTekrari = new System.Windows.Forms.TextBox();
            this.txt_YeniSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.grpBox_MailAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpBoz_SifreDegistirmeAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sorgula);
            this.groupBox1.Controls.Add(this.cmb_GuvenlikSorusu);
            this.groupBox1.Controls.Add(this.txt_GuvenlikCevabi);
            this.groupBox1.Controls.Add(this.txt_KullaniciAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 378);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güvenlik Soru Yöntemi";
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sorgula.ImageIndex = 0;
            this.btn_sorgula.ImageList = this.ımageList1;
            this.btn_sorgula.Location = new System.Drawing.Point(184, 159);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(116, 44);
            this.btn_sorgula.TabIndex = 3;
            this.btn_sorgula.Text = "Sorgula";
            this.btn_sorgula.UseVisualStyleBackColor = true;
            this.btn_sorgula.Click += new System.EventHandler(this.btn_sorgula_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Guvenliksorusu.ico");
            // 
            // cmb_GuvenlikSorusu
            // 
            this.cmb_GuvenlikSorusu.FormattingEnabled = true;
            this.cmb_GuvenlikSorusu.Location = new System.Drawing.Point(128, 75);
            this.cmb_GuvenlikSorusu.Name = "cmb_GuvenlikSorusu";
            this.cmb_GuvenlikSorusu.Size = new System.Drawing.Size(193, 21);
            this.cmb_GuvenlikSorusu.TabIndex = 1;
            // 
            // txt_GuvenlikCevabi
            // 
            this.txt_GuvenlikCevabi.Location = new System.Drawing.Point(128, 116);
            this.txt_GuvenlikCevabi.Name = "txt_GuvenlikCevabi";
            this.txt_GuvenlikCevabi.Size = new System.Drawing.Size(193, 20);
            this.txt_GuvenlikCevabi.TabIndex = 2;
            this.txt_GuvenlikCevabi.TextChanged += new System.EventHandler(this.txt_GuvenlikCevabi_TextChanged);
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(128, 36);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(193, 20);
            this.txt_KullaniciAdi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Güvenlik Cevabı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güvenlik Sorusu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // grpBox_MailAlani
            // 
            this.grpBox_MailAlani.Controls.Add(this.timerLabel);
            this.grpBox_MailAlani.Controls.Add(this.pictureBox2);
            this.grpBox_MailAlani.Controls.Add(this.btn_DogrulamaKoduOnayla);
            this.grpBox_MailAlani.Controls.Add(this.btn_DogrulamaKoduGonder);
            this.grpBox_MailAlani.Controls.Add(this.txt_DogrulamaKodu);
            this.grpBox_MailAlani.Controls.Add(this.txt_Email);
            this.grpBox_MailAlani.Controls.Add(this.label4);
            this.grpBox_MailAlani.Controls.Add(this.label5);
            this.grpBox_MailAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBox_MailAlani.Location = new System.Drawing.Point(360, 13);
            this.grpBox_MailAlani.Name = "grpBox_MailAlani";
            this.grpBox_MailAlani.Size = new System.Drawing.Size(306, 203);
            this.grpBox_MailAlani.TabIndex = 1;
            this.grpBox_MailAlani.TabStop = false;
            this.grpBox_MailAlani.Text = "Mail Alanı";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(145, 139);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(15, 13);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "..";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btn_DogrulamaKoduOnayla
            // 
            this.btn_DogrulamaKoduOnayla.Location = new System.Drawing.Point(224, 170);
            this.btn_DogrulamaKoduOnayla.Name = "btn_DogrulamaKoduOnayla";
            this.btn_DogrulamaKoduOnayla.Size = new System.Drawing.Size(75, 23);
            this.btn_DogrulamaKoduOnayla.TabIndex = 3;
            this.btn_DogrulamaKoduOnayla.Text = "Onayla";
            this.btn_DogrulamaKoduOnayla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DogrulamaKoduOnayla.UseVisualStyleBackColor = true;
            this.btn_DogrulamaKoduOnayla.Click += new System.EventHandler(this.btn_DogrulamaKoduOnayla_Click);
            // 
            // btn_DogrulamaKoduGonder
            // 
            this.btn_DogrulamaKoduGonder.Location = new System.Drawing.Point(145, 65);
            this.btn_DogrulamaKoduGonder.Name = "btn_DogrulamaKoduGonder";
            this.btn_DogrulamaKoduGonder.Size = new System.Drawing.Size(155, 38);
            this.btn_DogrulamaKoduGonder.TabIndex = 2;
            this.btn_DogrulamaKoduGonder.Text = "Doğrulama Kodu Gönder";
            this.btn_DogrulamaKoduGonder.UseVisualStyleBackColor = true;
            this.btn_DogrulamaKoduGonder.Click += new System.EventHandler(this.btn_DogrulamaKoduGonder_Click);
            // 
            // txt_DogrulamaKodu
            // 
            this.txt_DogrulamaKodu.Location = new System.Drawing.Point(145, 172);
            this.txt_DogrulamaKodu.Name = "txt_DogrulamaKodu";
            this.txt_DogrulamaKodu.Size = new System.Drawing.Size(74, 20);
            this.txt_DogrulamaKodu.TabIndex = 1;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(145, 33);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(155, 20);
            this.txt_Email.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(22, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Doğrulama Kodu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(22, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email Adresiniz:";
            // 
            // grpBoz_SifreDegistirmeAlani
            // 
            this.grpBoz_SifreDegistirmeAlani.Controls.Add(this.pictureBox1);
            this.grpBoz_SifreDegistirmeAlani.Controls.Add(this.btn_SifreDegistir);
            this.grpBoz_SifreDegistirmeAlani.Controls.Add(this.txt_YeniSifreTekrari);
            this.grpBoz_SifreDegistirmeAlani.Controls.Add(this.txt_YeniSifre);
            this.grpBoz_SifreDegistirmeAlani.Controls.Add(this.label7);
            this.grpBoz_SifreDegistirmeAlani.Controls.Add(this.label6);
            this.grpBoz_SifreDegistirmeAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBoz_SifreDegistirmeAlani.Location = new System.Drawing.Point(360, 222);
            this.grpBoz_SifreDegistirmeAlani.Name = "grpBoz_SifreDegistirmeAlani";
            this.grpBoz_SifreDegistirmeAlani.Size = new System.Drawing.Size(306, 169);
            this.grpBoz_SifreDegistirmeAlani.TabIndex = 3;
            this.grpBoz_SifreDegistirmeAlani.TabStop = false;
            this.grpBoz_SifreDegistirmeAlani.Text = "Şifre Değiştirme Alanı";
            this.grpBoz_SifreDegistirmeAlani.Enter += new System.EventHandler(this.grpBoz_SifreDegistirme_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_SifreDegistir
            // 
            this.btn_SifreDegistir.Location = new System.Drawing.Point(204, 126);
            this.btn_SifreDegistir.Name = "btn_SifreDegistir";
            this.btn_SifreDegistir.Size = new System.Drawing.Size(95, 23);
            this.btn_SifreDegistir.TabIndex = 3;
            this.btn_SifreDegistir.Text = "Şifre Değiştir";
            this.btn_SifreDegistir.UseVisualStyleBackColor = true;
            this.btn_SifreDegistir.Click += new System.EventHandler(this.btn_SifreDegistir_Click);
            // 
            // txt_YeniSifreTekrari
            // 
            this.txt_YeniSifreTekrari.Location = new System.Drawing.Point(144, 76);
            this.txt_YeniSifreTekrari.Name = "txt_YeniSifreTekrari";
            this.txt_YeniSifreTekrari.Size = new System.Drawing.Size(155, 20);
            this.txt_YeniSifreTekrari.TabIndex = 0;
            // 
            // txt_YeniSifre
            // 
            this.txt_YeniSifre.Location = new System.Drawing.Point(144, 35);
            this.txt_YeniSifre.Name = "txt_YeniSifre";
            this.txt_YeniSifre.Size = new System.Drawing.Size(155, 20);
            this.txt_YeniSifre.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yeni Şifre Tekrarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yeni Şifre:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 397);
            this.Controls.Add(this.grpBoz_SifreDegistirmeAlani);
            this.Controls.Add(this.grpBox_MailAlani);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştirme";
            this.Load += new System.EventHandler(this.SifreDegistirme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBox_MailAlani.ResumeLayout(false);
            this.grpBox_MailAlani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpBoz_SifreDegistirmeAlani.ResumeLayout(false);
            this.grpBoz_SifreDegistirmeAlani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sorgula;
        private System.Windows.Forms.ComboBox cmb_GuvenlikSorusu;
        private System.Windows.Forms.TextBox txt_GuvenlikCevabi;
        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBox_MailAlani;
        private System.Windows.Forms.Button btn_DogrulamaKoduOnayla;
        private System.Windows.Forms.Button btn_DogrulamaKoduGonder;
        private System.Windows.Forms.TextBox txt_DogrulamaKodu;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpBoz_SifreDegistirmeAlani;
        private System.Windows.Forms.Button btn_SifreDegistir;
        private System.Windows.Forms.TextBox txt_YeniSifreTekrari;
        private System.Windows.Forms.TextBox txt_YeniSifre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer1;
    }
}