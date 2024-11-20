using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinemaSistemiv1.Data
{
    public class Salonlar
    {
        [Key]
        public int salon_id { get; set; }

        public string salon_adi { get; set; }

        public int toplam_koltuk_sayisi { get; set; }

        public ICollection<Seanslar> Seanslar { get; set; } = new List<Seanslar>();
        public ICollection<Koltuklar> Koltuklar { get; set; } = new List<Koltuklar>();
        public ICollection<SatisRaporlari> SatisRaporlari { get; set; } = new List<SatisRaporlari>();
    }
}
