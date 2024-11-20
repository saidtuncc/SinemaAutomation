using Microsoft.EntityFrameworkCore;
using SinemaSistemiv1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSistemiv1.Login
{
    public partial class FrmKayitol : Form
    {
        public FrmKayitol()
        {
            InitializeComponent();
        }

        private void lblKayitOlKayitol_Click(object sender, EventArgs e)
        {

        }

        private void lblEpostaKayitOl_Click(object sender, EventArgs e)
        {

        }

        private void txtEpostaKayitOl_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSifre_Click(object sender, EventArgs e)
        {

        }

        private void txtSifreKayitOl_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSifreTekrar_Click(object sender, EventArgs e)
        {

        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnKayitolKayitol_Click(object sender, EventArgs e)
        {
            if (txtSifreKayitOl.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor!");
                return;
            }

            string email = txtEpostaKayitOl.Text;
            string sifre = txtSifreKayitOl.Text;
            string kullaniciAdi = txtKullaniciAdi.Text;

            var options = new DbContextOptionsBuilder<SinemaSistemiContext>()
                             .UseMySql("Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;",
                                       new MySqlServerVersion(new Version(8, 0, 21)))
                             .Options;

            using (var context = new SinemaSistemiContext(options))
            {
               
                var mevcutKullanici = context.Kullanicilar
                                             .FirstOrDefault(k => k.kullanici_adi == kullaniciAdi);

                if (mevcutKullanici != null)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor, lütfen farklı bir kullanıcı adı girin.");
                    return;
                }

                var yeniKullanici = new Kullanicilar
                {
                    email = email,
                    sifre = sifre,
                    kullanici_adi = kullaniciAdi,  
                    rol = "kullanici",
                };

                context.Kullanicilar.Add(yeniKullanici);
                context.SaveChanges();

                MessageBox.Show("Kayıt başarılı!");

                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void FrmKayitol_Load(object sender, EventArgs e)
        {
        }
    }
}
