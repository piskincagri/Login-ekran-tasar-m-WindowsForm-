using market.controller;
using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Reflection.Emit;

namespace market
{
    public partial class SifreDegistirme : Form
    {
        int code;
        private Timer timer;
        private int remainingSeconds;
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            Controller controler = new Controller();
            timer = new Timer();
            timer.Interval = 120000; // 1 saniye
            timer.Tick += Timer_Tick;
            timerLabel.Text = "2:00"; // Başlangıçta 2 dakika gösterilsin

            List<LoginTable> loginTableList = controler.getLoginTable();
            grpBox_MailAlani.Enabled = false;
            grpBoz_SifreDegistirmeAlani.Enabled = false;

            foreach (LoginTable lt in loginTableList)
            {
                cmb_GuvenlikSorusu.Items.Add(lt.guvenlikSorusu.ToString());

            }
     
            cmb_GuvenlikSorusu.SelectedIndex = 0;


        }

        private void grpBoz_SifreDegistirme_Enter(object sender, EventArgs e)
        {

        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
          LoginStatus result = controller.doAuthentication(txt_KullaniciAdi.Text.Trim().ToLower(), cmb_GuvenlikSorusu.SelectedItem.ToString(), txt_GuvenlikCevabi.Text.ToLower());

            if (result == LoginStatus.basarili)
            {

                grpBox_MailAlani.Enabled = true;
            }
            else if (result == LoginStatus.basarisiz)
            {

                MessageBox.Show("Girdiğiniz Bilgileri Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!","HATA",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_DogrulamaKoduGonder_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            string emailAdres = controller.checkEmailAddress(txt_KullaniciAdi.Text);

            if (emailAdres == txt_Email.Text)
            {
                Random rdn = new Random();
                code = rdn.Next(100000, 999999);

                MailAddress mailAlan = new MailAddress(txt_Email.Text, txt_KullaniciAdi.Text);

                MailAddress mailGonderen = new MailAddress("cagri33@hotmail.com", "cagri piskin");
                MailMessage mesaj = new MailMessage();

                mesaj.To.Add(mailAlan);
                mesaj.From = mailGonderen;

                mesaj.Subject = "Şifre Değiştirme";


                mesaj.Body = "Şifrenizi değiştirmek için doğrulama kodunuz:" + code;

                SmtpClient smtp = new SmtpClient("smtp.office365.com", 587
                    );
                smtp.Credentials = new System.Net.NetworkCredential("cagri33@hotmail.com", "Cagri1979");
                smtp.EnableSsl = true;
                smtp.Send(mesaj);
                MessageBox.Show("Doğrulama Kodu Gönderildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Doğrulama kodunun geçerlilik süresini başlat
                remainingSeconds = 120;
                UpdateTimerLabel();

                timer.Start();

            }
            else
            {

                MessageBox.Show("Hesabınıza bağlı mail adresinizi giriniz ", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
                
        }
       


        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;

            if (remainingSeconds >= 0)
            {
                UpdateTimerLabel();
            }
            else
            {
                timer.Stop();
                MessageBox.Show("Doğrulama kodu süresi doldu.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTimerLabel()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(remainingSeconds);
            timerLabel.Text = string.Format("{0}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
        }
        private string FormatRemainingTime()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(remainingSeconds);
            return string.Format("{0}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
        }

        private void btn_DogrulamaKoduOnayla_Click(object sender, EventArgs e)
        {

            if(txt_DogrulamaKodu.Text==code.ToString())
            {
                grpBoz_SifreDegistirmeAlani.Enabled = true;

                MessageBox.Show("LÜTFEN YENİ ŞİFRENİZİ TANIMLAYINIZ!", "BİLGİ !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("DOĞRULAMA KODUNUZ YANLIŞTIR.", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void btn_SifreDegistir_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            if (txt_YeniSifre.Text == txt_YeniSifreTekrari.Text)
            {

                LoginStatus result = controller.changePassword(txt_KullaniciAdi.Text, txt_YeniSifre.Text);

                if (result == LoginStatus.basarili)
                {

                    MessageBox.Show("ŞİFRENİZ DEĞİŞTİRİLMİŞTİR", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("İLGİLİ ALANLARI DOLDURUNUZ.", "UYARI !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {

                MessageBox.Show("ŞİFRE TEKRARINI HATALI YAPTINIZ.", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_GuvenlikCevabi_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
