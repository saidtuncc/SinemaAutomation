using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinemaSistemiv1.Data
{
    public class Kullanicilar
    {
        [Key]
        public int kullanici_id { get; set; }
        public string kullanici_adi {  get; set; }

        public string email { get; set; }

        public string sifre { get; set; }

        public string rol { get; set; } // 'kullanici', 'calisan', 'yonetici'

        public DateTime kayit_tarihi { get; set; } = DateTime.Now;

        public ICollection<Biletler> Biletler { get; set; } = new List<Biletler>();
    } 
}
