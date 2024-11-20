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

namespace SinemaSistemiv1.FormAdmin
{
    public partial class FrmHalkGunu : Form
    {
        private SinemaSistemiContext _context;
        public FrmHalkGunu()
        {
            InitializeComponent();
            var options = new DbContextOptionsBuilder<SinemaSistemiContext>()
            .UseMySql("Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;", new MySqlServerVersion(new Version(8, 0, 21)))
             .Options;
            _context = new SinemaSistemiContext(options);
        }

        private void FrmHalkGunu_Load(object sender, EventArgs e)
        {
            ComboxGunSecin.Items.Add("Pazartesi");
            ComboxGunSecin.Items.Add("Salı");
            ComboxGunSecin.Items.Add("Çarşamba");
            ComboxGunSecin.Items.Add("Perşembe");
            ComboxGunSecin.Items.Add("Cuma");
            ComboxGunSecin.Items.Add("Cumartesi");
            ComboxGunSecin.Items.Add("Pazar");
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string secilenGun = ComboxGunSecin.SelectedItem.ToString();
                decimal fiyat = NumFiyatBelirle.Value;

                var mevcutHalkGunu = _context.HalkGunu.FirstOrDefault(hg => hg.gun == secilenGun);

                if (mevcutHalkGunu != null)
                {
                    
                    mevcutHalkGunu.fiyat = fiyat;
                    _context.HalkGunu.Update(mevcutHalkGunu);
                }
                else
                {
                    
                    var halkGunu = new HalkGunu
                    {
                        gun = secilenGun,
                        fiyat = fiyat
                    };
                    _context.HalkGunu.Add(halkGunu);
                }

                
                _context.SaveChanges();

                MessageBox.Show("Halk günü başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Halk günü kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
