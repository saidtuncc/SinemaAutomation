using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SinemaSistemiv1.Data;
using Microsoft.EntityFrameworkCore;

namespace SinemaSistemiv1.FormKullanıcı
{
    public partial class FrmBilgiGuncelleme : Form
    {
        private int _kullaniciId;
        public FrmBilgiGuncelleme(int kullaniciId)
        {
            InitializeComponent();
            _kullaniciId = kullaniciId;
        }
        private void BtnGuncelleBlgileriniGuncelle_Click(object sender, EventArgs e)
        {
            string currentPasswordInput = txtMevcutSifreBilgiGuncelle.Text;
            string newPassword = txtSifreBilgiGuncelle.Text;
            string confirmPassword = txtSifreTekrarBilgiGuncelle.Text;

            var options = new DbContextOptionsBuilder<SinemaSistemiContext>()
                             .UseMySql("Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;",
                                       new MySqlServerVersion(new Version(8, 0, 21)))
                             .Options;

            using (var context = new SinemaSistemiContext(options))
            {
                
                var kullanici = context.Kullanicilar
                    .Where(k => k.kullanici_id == _kullaniciId)
                    .FirstOrDefault();

                if (kullanici != null)
                {
                    
                    if (currentPasswordInput != kullanici.sifre)
                    {
                        MessageBox.Show("Mevcut şifrenizi yanlış girdiniz!");
                        return;
                    }

                    
                    if (newPassword != confirmPassword)
                    {
                        MessageBox.Show("Yeni şifreler uyuşmuyor!");
                        return;
                    }

                    
                    kullanici.sifre = newPassword;

                    
                    context.SaveChanges();

                    MessageBox.Show("Şifreniz başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı.");
                }
            }
        }

        private void lblBilgileriniziGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void lblSifreBilgiGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void txtSifreBilgiGuncelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSifreTekrarBilgiGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void lblMevcutSifreBilgiGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void txtMevcutSifreBilgiGuncelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmBilgiGuncelleme_Load(object sender, EventArgs e)
        {

        }
    }
}
