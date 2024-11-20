using Microsoft.EntityFrameworkCore;
using SinemaSistemiv1.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SinemaSistemiv1.FrmAdmin
{
    public partial class FrmKullanicilariDuzenle : Form
    {
        private SinemaSistemiContext _context;

        public FrmKullanicilariDuzenle()
        {
            InitializeComponent();
            var options = new DbContextOptionsBuilder<SinemaSistemiContext>()
                .UseMySql("Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;", new MySqlServerVersion(new Version(8, 0, 21)))
                .Options;
            _context = new SinemaSistemiContext(options);
            LoadUsers();
            LoadRoles();
        }

        
        private void LoadUsers()
        {
            var users = _context.Kullanicilar.ToList();
            dataGridViewUser.DataSource = users;
        }

        
        private void LoadRoles()
        {
            var roles = new[] { "kullanici", "calisan", "yonetici" };
            ComBoxRol.DataSource = roles;
        }
        private void FrmKullanicilariDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var newUser = new Kullanicilar
                {
                    email = txtEmail.Text,
                    sifre = txtSifre.Text,
                    rol = ComBoxRol.SelectedItem.ToString()
                };

                _context.Kullanicilar.Add(newUser);
                _context.SaveChanges();
                LoadUsers(); 
                MessageBox.Show("Kullanıcı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUser.SelectedRows.Count > 0)
                {
                    int userId = Convert.ToInt32(dataGridViewUser.SelectedRows[0].Cells["kullanici_id"].Value);
                    var user = _context.Kullanicilar.FirstOrDefault(u => u.kullanici_id == userId);

                    if (user != null)
                    {
                        _context.Kullanicilar.Remove(user);
                        _context.SaveChanges();
                        LoadUsers(); 
                        MessageBox.Show("Kullanıcı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewUser.SelectedRows.Count > 0)
                {
                    int userId = Convert.ToInt32(dataGridViewUser.SelectedRows[0].Cells["kullanici_id"].Value);
                    var user = _context.Kullanicilar.FirstOrDefault(u => u.kullanici_id == userId);

                    if (user != null)
                    {
                        user.email = txtEmail.Text;
                        user.sifre = txtSifre.Text;
                        user.rol = ComBoxRol.SelectedItem.ToString();

                        _context.SaveChanges();
                        LoadUsers(); 
                        MessageBox.Show("Kullanıcı başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}


