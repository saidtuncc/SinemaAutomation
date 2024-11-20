using Microsoft.EntityFrameworkCore;
using SinemaSistemiv1.Data;
using SinemaSistemiv1.FormKullanıcı;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SinemaSistemiv1.FormCalisan
{
    public partial class FrmFilmSeanslariCalisan : Form
    {
        private readonly SinemaSistemiContext _context;
        private int _selectedSeansId;
        private List<int> _selectedSeats = new List<int>();
        
        private int _currentUserId;

        public FrmFilmSeanslariCalisan(int userID)
        {
            InitializeComponent();
            var options = new DbContextOptionsBuilder<SinemaSistemiContext>()
                .UseMySql("Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;", new MySqlServerVersion(new Version(8, 0, 21)))
                .Options;
            _context = new SinemaSistemiContext(options);
            _currentUserId = userID;
        }

        private void FrmFilmSeanslariCalisan_Load(object sender, EventArgs e)
        {
            var films = _context.Filmler.ToList();
            panelFilmSeansCalisan.Controls.Clear();

            int panelHeight = 0;

            foreach (var film in films)  
            {
                Panel filmPanel = new Panel
                {
                    Width = panelFilmSeansCalisan.Width - 100,
                    Height = 220,
                    Location = new Point(0, panelHeight),
                    BorderStyle = BorderStyle.FixedSingle
                };

                panelHeight += filmPanel.Height + 10;

                if (film.poster_goruntu != null)
                {
                    using (MemoryStream ms = new MemoryStream(film.poster_goruntu))
                    {
                        PictureBox pictureBox = new PictureBox
                        {
                            Image = Image.FromStream(ms),
                            Width = 120,
                            Height = 180,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Location = new Point(10, 10)
                        };
                        filmPanel.Controls.Add(pictureBox);
                    }
                }

                Label lblBaslik = new Label
                {
                    Text = film.baslik,
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    Location = new Point(140, 10),
                    AutoSize = true
                };
                filmPanel.Controls.Add(lblBaslik);

                Label lblRating = new Label
                {
                    Text = $"Rating: {film.rating}",
                    Location = new Point(140, 40),
                    AutoSize = true
                };
                filmPanel.Controls.Add(lblRating);

                Label lblSure = new Label
                {
                    Text = $"Süre: {film.sure} dakika",
                    Location = new Point(140, 60),
                    AutoSize = true
                };
                filmPanel.Controls.Add(lblSure);

                Label lblTur = new Label
                {
                    Text = $"Tür: {film.tur}",
                    Location = new Point(140, 80),
                    AutoSize = true
                };
                filmPanel.Controls.Add(lblTur);

                Label lblAciklama = new Label
                {
                    Text = $"Açıklama: {film.aciklama}",
                    Location = new Point(140, 100),
                    AutoSize = true
                };
                filmPanel.Controls.Add(lblAciklama);

                var seanslar = _context.Seanslar.Where(s => s.film_id == film.film_id).OrderBy(s => s.seans_saati.TimeOfDay).ToList();
                ComboBox cbSeanslar = new ComboBox
                {
                    Location = new Point(140, 130),
                    Width = 200
                };
                
                foreach (var seans in seanslar)
                {
                    cbSeanslar.Items.Add(new ComboBoxItem
                    {
                        Text = seans.seans_saati.ToString("HH:mm"),
                        Value = seans.seans_id
                    });
                }

                if (seanslar.Count > 0)
                {
                    cbSeanslar.SelectedIndex = 0;
                    _selectedSeansId = seanslar[0].seans_id;
                    LoadSeats(_selectedSeansId);
                }

                cbSeanslar.SelectedIndexChanged += (s, ev) =>
                {
                    if (cbSeanslar.SelectedItem is ComboBoxItem selectedItem)
                    {
                        _selectedSeansId = selectedItem.Value;
                        LoadSeats(_selectedSeansId);
                    }
                };

                filmPanel.Controls.Add(cbSeanslar);

                Button btnBiletSatinAl = new Button
                {
                    Text = "Bilet Satın Al",
                    Location = new Point(140, 160),
                    Width = 100
                };
                btnBiletSatinAl.Click += BtnBiletSatinAl_Click;
                filmPanel.Controls.Add(btnBiletSatinAl);

                panelFilmSeansCalisan.Controls.Add(filmPanel);
            }

            panelFilmSeansCalisan.Height = panelHeight;
            panelFilmSeansCalisan.Width = 700;
        }

        private void LoadSeats(int seansId)
        {
            var seans = _context.Seanslar.Find(seansId);
            var koltuklar = _context.Koltuklar.Where(k => k.seans_id == seansId).ToList();

            Panel panelSeats = new Panel
            {
                Location = new Point(panelFilmSeansCalisan.Width - 250, 0),
                Width = 200,
                Height = panelFilmSeansCalisan.Height,
                BorderStyle = BorderStyle.FixedSingle
            };

            panelSeats.Controls.Clear();

            int say = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (say < koltuklar.Count)
                    {
                        var koltuk = koltuklar[say];

                        Button btnKoltuk = new Button
                        {
                            Name = "btnKoltuk" + koltuk.koltuk_id,
                            Text = koltuk.koltuk_numarasi,
                            Width = 30,
                            Height = 30,
                            Left = 35 * j,
                            Top = 35 * i,
                            BackColor = koltuk.durum == "bos" ? Color.Green : Color.Red,
                            Enabled = koltuk.durum == "bos"
                        };

                        btnKoltuk.Click += (sender, e) => KoltukSecildi(koltuk.koltuk_id, btnKoltuk);

                        panelSeats.Controls.Add(btnKoltuk);
                    }
                    say++;
                }
            }

            var oldPanelSeats = panelFilmSeansCalisan.Controls.OfType<Panel>().FirstOrDefault(p => p.Name == "panelSeats");
            if (oldPanelSeats != null)
            {
                panelFilmSeansCalisan.Controls.Remove(oldPanelSeats);
            }

            panelSeats.Name = "panelSeats";
            panelFilmSeansCalisan.Controls.Add(panelSeats);
        }
        private Dictionary<int, string> _koltukTuru = new Dictionary<int, string>();
        private void KoltukSecildi(int koltukId, Button btnKoltuk)
        {
            if (_selectedSeats.Contains(koltukId))
            {
                _selectedSeats.Remove(koltukId);
                _koltukTuru.Remove(koltukId); 
                btnKoltuk.BackColor = Color.Green; 
            }
            else
            {
                using (FrmKullaniciTuru kullaniciTuruFormu = new FrmKullaniciTuru())
                {
                    if (kullaniciTuruFormu.ShowDialog() == DialogResult.OK)
                    {
                        string kullaniciTuru = kullaniciTuruFormu.KullaniciTuru;

                        
                        _selectedSeats.Add(koltukId);
                        _koltukTuru[koltukId] = kullaniciTuru; 
                        btnKoltuk.BackColor = Color.Aqua; 
                    }
                }
            }
        }

        private void BtnBiletSatinAl_Click(object sender, EventArgs e)
        {
            if (_selectedSeats.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir koltuk seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string bugunGun = DateTime.Now.DayOfWeek switch
            {
                DayOfWeek.Monday => "Pazartesi",
                DayOfWeek.Tuesday => "Salı",
                DayOfWeek.Wednesday => "Çarşamba",
                DayOfWeek.Thursday => "Perşembe",
                DayOfWeek.Friday => "Cuma",
                DayOfWeek.Saturday => "Cumartesi",
                DayOfWeek.Sunday => "Pazar",
                _ => ""
            };

            var halkGunu = _context.HalkGunu.FirstOrDefault(hg => hg.gun == bugunGun);

            decimal totalAmount = 0;

            foreach (var koltukId in _selectedSeats)
            {
                decimal fiyat;

                if (halkGunu != null)
                {
                    
                    fiyat = halkGunu.fiyat;
                }
                else
                {
                    
                    string kullaniciTuru = _koltukTuru[koltukId];
                    fiyat = kullaniciTuru == "ogrenci" ? 75 : 100;
                }

                totalAmount += fiyat;
            }

            FrmSatisOnay satisOnayFormu = new FrmSatisOnay(Convert.ToInt32(totalAmount));
            if (satisOnayFormu.ShowDialog() == DialogResult.OK)
            {
                var odemeTuru = satisOnayFormu.OdemeTuru;

                foreach (var koltukId in _selectedSeats)
                {
                    var koltuk = _context.Koltuklar.Find(koltukId);
                    koltuk.durum = "satin_alindi";

                    decimal fiyat = halkGunu?.fiyat ?? (_koltukTuru[koltukId] == "ogrenci" ? 75:100);

                    string kullaniciTuru = _koltukTuru[koltukId];

                    var bilet = new Biletler
                    {
                        seans_id = _selectedSeansId,
                        Kullanici_id = _currentUserId,
                        koltuk_numarasi = koltuk.koltuk_numarasi,
                        fiyat = totalAmount / _selectedSeats.Count, 
                        odeme_turu = odemeTuru,
                        durum = "satin_alindi",
                        kullanici_turu = kullaniciTuru
                    };

                    _context.Biletler.Add(bilet);
                }
                _context.SaveChanges();
                MessageBox.Show("Biletler satışa işlendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Satış işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString() 
            {
                return Text;
            }
        }
    }
}
