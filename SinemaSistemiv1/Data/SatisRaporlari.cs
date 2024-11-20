using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinemaSistemiv1.Data
{
    public class SatisRaporlari
    {
        [Key]
        public int rapor_id { get; set; }

        public DateTime rapor_tarihi { get; set; }

        public int toplam_bilet_sayisi { get; set; }

        public decimal toplam_satis { get; set; }

        [ForeignKey(nameof(Salon))]
        public int salon_id { get; set; }
        public Salonlar Salon { get; set; }
    }
}
