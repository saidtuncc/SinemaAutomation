using Microsoft.EntityFrameworkCore;
using SinemaSistemiv1.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SinemaSistemiv1.FrmAdmin
{
    public partial class FrmFilmSeansDuzenle : Form
    {
        private SinemaSistemiContext _context;

        public FrmFilmSeansDuzenle()
        {
            InitializeComponent();
            var options = new DbContextOptionsBuilder<SinemaSistemiContext>()
                .UseMySql("Server=localhost;Port=3306;Database=sinema_sistemi;User=root;Password=saidtunc123;", new MySqlServerVersion(new Version(8, 0, 21)))
                .Options;
            _context = new SinemaSistemiContext(options);
        }

        private void FrmFilmSeansDuzenle_Load(object sender, EventArgs e)
        {
            LoadFilms();
            LoadSalons();
            SetupDateTimePicker();
        }

        private void LoadFilms()
        {
            var films = _context.Filmler
                                .Include(f => f.Seanslar) 
                                .ToList();

            var filmData = films.Select(f => new
            {
                f.film_id,
                f.baslik,
                f.sure,
                f.tur,
                f.rating,
                Seanslar = string.Join(", ", f.Seanslar.Select(s => s.seans_saati.ToString("HH:mm")))
            }).ToList();

            dataGridView1.DataSource = filmData;
            dataGridView1.Columns["film_id"].Visible = false; 

            
            ComboxFilmSecimi.DataSource = films;
            ComboxFilmSecimi.DisplayMember = "baslik";
            ComboxFilmSecimi.ValueMember = "film_id";
        }



        private void LoadSalons()
        {
            var salonlar = _context.Salonlar.ToList();
            ComboxSalonSecimi.DataSource = salonlar;
            ComboxSalonSecimi.DisplayMember = "salon_adi";
            ComboxSalonSecimi.ValueMember = "salon_id";
        }

        private void SetupDateTimePicker()
        {

            datetimeSeansSaati.Format = DateTimePickerFormat.Custom;
            datetimeSeansSaati.CustomFormat = "HH:mm";
            datetimeSeansSaati.ShowUpDown = true;
        }

        private byte[] ConvertImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        private void BtnFilmEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                var newFilm = new Filmler
                {
                    baslik = txtFilmBaslik.Text,
                    sure = int.Parse(txtFilmSure.Text),
                    tur = txtFilmTuru.Text,
                    rating = float.Parse(txtFilmRating.Text),
                    aciklama = rtxtFilmAciklama.Text,
                    poster_goruntu = pictureBox1.Image != null ? ConvertImageToByteArray(pictureBox1.Image) : null
                };

                _context.Filmler.Add(newFilm);
                _context.SaveChanges();
                LoadFilms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bütün Bilgileri Girdiğinizden emin olun");
            }
        }

        private void BtnSeansEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedSalonId = (int)ComboxSalonSecimi.SelectedValue;

                var seans = new Seanslar
                {
                    film_id = (int)ComboxFilmSecimi.SelectedValue,
                    salon_id = selectedSalonId,
                    seans_saati = datetimeSeansSaati.Value
                };

                _context.Seanslar.Add(seans);
                _context.SaveChanges();

                MessageBox.Show("Seans başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seans eklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnPosterYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int filmId;
                if (!int.TryParse(dataGridView1.SelectedRows[0].Cells["film_id"].Value.ToString(), out filmId))
                {
                    MessageBox.Show("Geçerli bir film ID'si seçilmedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var film = _context.Filmler.Include(f => f.Seanslar).FirstOrDefault(f => f.film_id == filmId);

                if (film != null)
                {
                    
                    if (!string.IsNullOrEmpty(txtFilmBaslik.Text))
                    {
                        film.baslik = txtFilmBaslik.Text;
                    }

                    if (int.TryParse(txtFilmSure.Text, out int filmSure))
                    {
                        film.sure = filmSure;
                    }

                    if (!string.IsNullOrEmpty(txtFilmTuru.Text))
                    {
                        film.tur = txtFilmTuru.Text;
                    }

                    if (float.TryParse(txtFilmRating.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float filmRating))
                    {
                        film.rating = filmRating;
                    }

                    if (!string.IsNullOrEmpty(rtxtFilmAciklama.Text))
                    {
                        film.aciklama = rtxtFilmAciklama.Text;
                    }

                    if (pictureBox1.Image != null)
                    {
                        film.poster_goruntu = ConvertImageToByteArray(pictureBox1.Image);
                    }

                    _context.SaveChanges();
                    LoadFilms();
                    MessageBox.Show("Film başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }




        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int filmId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["film_id"].Value);
                var film = _context.Filmler.Include(f => f.Seanslar).FirstOrDefault(f => f.film_id == filmId);

                if (film != null)
                {
                    
                    _context.Seanslar.RemoveRange(film.Seanslar);

                    
                    _context.Filmler.Remove(film);
                    _context.SaveChanges();
                    LoadFilms();
                    MessageBox.Show("Film ve ilişkili seanslar başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
