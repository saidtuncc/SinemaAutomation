using SinemaSistemiv1.Data;
using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace SinemaSistemiv1.Login
{
    public partial class FrmSifremiUnuttum : Form
    {
        public FrmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void BtnGeriSifreUnuttum_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Hide();
        }

        private void BtnGonderSifremiUnuttum_Click(object sender, EventArgs e)
        {
            string email = txtEpostaSifreUnuttum.Text;

            var options = new DbContextOptionsBuilder<SinemaSistemiContext>()
                             .UseMySql("Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;",
                             new MySqlServerVersion(new Version(8, 0, 21)))
                             .Options;

            using (var context = new SinemaSistemiContext(options))
            {
                var kullanici = context.Kullanicilar
                    .Where(k => k.email == email)
                    .FirstOrDefault();

                if (kullanici != null)
                {
                    string geciciSifre = GenerateTemporaryPassword();
                    kullanici.sifre = geciciSifre;

                    context.SaveChanges();

                    SendTemporaryPasswordEmail(kullanici.email, geciciSifre);

                    MessageBox.Show("Geçici şifreniz e-posta adresinize gönderildi.");
                }
                else
                {
                    MessageBox.Show("Bu e-posta adresi ile kayıtlı bir kullanıcı bulunamadı.");
                }
            }
        }

        private string GenerateTemporaryPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void SendTemporaryPasswordEmail(string email, string temporaryPassword)
        {
            try
            {
                MailMessage ePosta = new MailMessage();
                ePosta.From = new MailAddress("opencinema00@outlook.com");
                ePosta.To.Add(email); 
                ePosta.Subject = "Geçici Şifre";
                ePosta.Body = $"Geçici şifreniz: {temporaryPassword}";

                SmtpClient client = new SmtpClient
                {
                    Credentials = new NetworkCredential("opencinema00@outlook.com", "Said123."),
                    Port = 587,
                    Host = "smtp.outlook.com",
                    EnableSsl = true
                };

                client.Send(ePosta);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"E-posta gönderilirken bir hata oluştu: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilinmeyen bir hata oluştu: {ex.Message}");
            }
        }

        private void FrmSifremiUnuttum_Load(object sender, EventArgs e)
        {

        }
        private void txtEpostaSifreUnuttum_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblSifremiUnuttumSifremiunuttum_Click(object sender, EventArgs e)
        {

        }
        private void lblEpostaSifreUnuttum_Click(object sender, EventArgs e)
        {

        }

    }
}





