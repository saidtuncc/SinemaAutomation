using SinemaSistemiv1.FrmAdmin;
using SinemaSistemiv1.Data;
using SinemaSistemiv1.FrmCalisan;
using SinemaSistemiv1.FormKullanıcı;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace SinemaSistemiv1.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtHosgeldiniz_Click(object sender, EventArgs e)
        {

        }

        private void lblEposta_Click(object sender, EventArgs e)
        {

        }

        private void lblSifre_Click(object sender, EventArgs e)
        {

        }

        private void txtEposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifremiUnuttum frm = new FrmSifremiUnuttum();
            frm.Show();
            this.Hide();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string email = txtEposta.Text;
            string sifre = txtSifre.Text;

            var options = new DbContextOptionsBuilder<SinemaSistemiContext>()
                             .UseMySql("Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;",
                                       new MySqlServerVersion(new Version(8, 0, 21)))
                             .Options;

            using (var context = new SinemaSistemiContext(options))
            {

                var kullanici = context.Kullanicilar
                    .Where(k => k.email == email && k.sifre == sifre)
                    .FirstOrDefault(); 


                if (kullanici != null)
                {
                    switch (kullanici.rol)
                    {
                        case "yonetici":
                            var adminPanel = new FrmAdmin.FrmAdmin(kullanici.kullanici_id);
                            adminPanel.Show();
                            this.Hide(); 
                            break;
                        case "calisan":
                            var calisanPanel = new FrmCalisan.FrmCalisan(kullanici.kullanici_id);
                            calisanPanel.Show();
                            this.Hide();
                            break;
                        case "kullanici":
                            FrmKullanıcı kullaniciPanel = new FrmKullanıcı(kullanici.kullanici_id);
                            kullaniciPanel.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Bilinmeyen bir rol ile giriş yapılmaya çalışılıyor.");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("E-posta veya şifre hatalı.");
                }
            }
        }

        private void BtnKayitol_Click(object sender, EventArgs e)
        {
            FrmKayitol frm = new FrmKayitol();
            frm.Show();
            this.Hide();
        }
    }
}
