using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanicigirisuygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullanici = tb_kadi.Text;
            string sifre = tb_sifre.Text;
            if (kullanici == "admin" && sifre == "12345")
            {
                MessageBox.Show("Hoşgeldin Admin", "Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Kullanıcı adını veya şifreyi kontol ediniz", "Giriş Başarısız");
            }
        }
    }
}
