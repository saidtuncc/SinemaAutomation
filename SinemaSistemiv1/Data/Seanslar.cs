using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinemaSistemiv1.Data
{
    public class Seanslar
    {
        [Key]
        public int seans_id { get; set; }

        [ForeignKey(nameof(Film))]
        public int film_id { get; set; }
        public Filmler Film { get; set; }

        [ForeignKey(nameof(Salon))]
        public int salon_id { get; set; }
        public Salonlar Salon { get; set; }

        public DateTime seans_saati { get; set; }

        public int kalan_koltuk_sayisi { get; set; }

        public ICollection<Biletler> Biletler { get; set; } = new List<Biletler>();
        public ICollection<Koltuklar> Koltuklar { get; set; } = new List<Koltuklar>();
    }
}
