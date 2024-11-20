using Microsoft.EntityFrameworkCore;
using SinemaSistemiv1.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SinemaSistemiv1.FormKullanıcı
{
    public partial class FrmSatinAlmaGecmisi : Form
    {
        private readonly SinemaSistemiContext _context;
        private int _currentUserId;

        public FrmSatinAlmaGecmisi(int kullaniciId)
        {
            InitializeComponent();

            var options = new DbContextOptionsBuilder<SinemaSistemiContext>()
                .UseMySql("Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;", new MySqlServerVersion(new Version(8, 0, 21)))
                .Options;
            _context = new SinemaSistemiContext(options);
            _currentUserId = kullaniciId;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var satinAlmaGecmisi = (from bilet in _context.Biletler
                                    join seans in _context.Seanslar on bilet.seans_id equals seans.seans_id
                                    join salon in _context.Salonlar on seans.salon_id equals salon.salon_id
                                    join film in _context.Filmler on seans.film_id equals film.film_id
                                    join kullanici in _context.Kullanicilar on bilet.Kullanici_id equals kullanici.kullanici_id
                                    where kullanici.kullanici_id == _currentUserId
                                    select new
                                    {
                                        kullanici.email,
                                        kullanici.kullanici_adi,
                                        bilet.koltuk_numarasi,
                                        bilet.fiyat,
                                        bilet.satin_alma_tarihi,
                                        bilet.durum,
                                        seans.seans_saati,
                                        salon.salon_adi,
                                        film.baslik
                                    }).ToList()
                                    .Select(x => new
                                    {
                                        x.kullanici_adi,
                                        x.email,
                                        x.koltuk_numarasi,
                                        x.fiyat,
                                        x.satin_alma_tarihi,
                                        x.durum,
                                        seans_saati = x.seans_saati.ToString("HH:mm"), 
                                        x.salon_adi,
                                        x.baslik
                                    }).ToList();

            dataGridViewSatinAlmaGecmisi.DataSource = satinAlmaGecmisi;

            if (dataGridViewSatinAlmaGecmisi.Columns["kullanici_adi"] != null)
                dataGridViewSatinAlmaGecmisi.Columns["kullanici_adi"].HeaderText = "Kullanıcı Adı";

            if (dataGridViewSatinAlmaGecmisi.Columns["email"] != null)
                dataGridViewSatinAlmaGecmisi.Columns["email"].HeaderText = "Email";

            if (dataGridViewSatinAlmaGecmisi.Columns["koltuk_numarasi"] != null)
                dataGridViewSatinAlmaGecmisi.Columns["koltuk_numarasi"].HeaderText = "Koltuk Numarası";

            if (dataGridViewSatinAlmaGecmisi.Columns["fiyat"] != null)
                dataGridViewSatinAlmaGecmisi.Columns["fiyat"].HeaderText = "Fiyat";

            if (dataGridViewSatinAlmaGecmisi.Columns["satin_alma_tarihi"] != null)
                dataGridViewSatinAlmaGecmisi.Columns["satin_alma_tarihi"].HeaderText = "Satın Alma Tarihi";

            if (dataGridViewSatinAlmaGecmisi.Columns["durum"] != null)
                dataGridViewSatinAlmaGecmisi.Columns["durum"].HeaderText = "Durum";

            if (dataGridViewSatinAlmaGecmisi.Columns["seans_saati"] != null)
                dataGridViewSatinAlmaGecmisi.Columns["seans_saati"].HeaderText = "Seans Saati";

            if (dataGridViewSatinAlmaGecmisi.Columns["salon_adi"] != null)
                dataGridViewSatinAlmaGecmisi.Columns["salon_adi"].HeaderText = "Salon Adı";

            if (dataGridViewSatinAlmaGecmisi.Columns["baslik"] != null)
                dataGridViewSatinAlmaGecmisi.Columns["baslik"].HeaderText = "Film Başlığı";
        }


        private void FrmSatinAlmaGecmisi_Load(object sender, EventArgs e) { }
    }
}
