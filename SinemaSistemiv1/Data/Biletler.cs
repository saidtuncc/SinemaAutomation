using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinemaSistemiv1.Data
{
    public class Biletler
    {
        [Key]
        public int bilet_id { get; set; }

        [ForeignKey(nameof(Seans))]
        public int seans_id { get; set; }
        public Seanslar Seans { get; set; }

        [ForeignKey(nameof(Kullanici))]
        public int Kullanici_id { get; set; }
        public Kullanicilar Kullanici { get; set; }

        [StringLength(10)]
        public string koltuk_numarasi { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal fiyat { get; set; }

        public DateTime satin_alma_tarihi { get; set; } = DateTime.Now;

        public string durum { get; set; } // 'rezerve', 'satin_alindi'

        public string odeme_turu { get; set; }
        public string kullanici_turu { get; set; }
    }
}
