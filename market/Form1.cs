using market.controller;
using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
           Controller controller = new Controller();
           User result = controller.login(txt_kullaniciAdi.Text, txt_sifre.Text);

            if(result!=null && result.status==LoginStatus.basarili && result.yetki =="admin")
            {
                //admin sayfasına gönder

                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Hide();

            }

            else if (result!=null &&result.status == LoginStatus.basarili && result.yetki == "kasiyer")
            {
                //kasiyer sayfasına gönder
                KasiyerPanel kasiyer = new KasiyerPanel();
                kasiyer.Show();
                this.Hide();


            }

            else if (result!=null && result.status==LoginStatus.basarisiz)
            {

                MessageBox.Show("Kullanıcı adı veya şifresi hatalıdır.", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Lütfen Kullanici Adı ve Şifre alanlarını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {
            SifreDegistirme SD = new SifreDegistirme();
            SD.Show();
            this.Hide();
        }
    }
}
