using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinemaSistemiv1.Data
{
    public class Koltuklar
    {
        [Key]
        public int koltuk_id { get; set; }

        [ForeignKey(nameof(Salon))]
        public int salon_id { get; set; }
        public Salonlar Salon { get; set; }

        [ForeignKey(nameof(Seans))]
        public int? seans_id { get; set; }  // Seans ID nullable olabilir, bazı koltuklar henüz bir seansla ilişkilendirilmeyebilir
        public Seanslar Seans { get; set; }

        public string koltuk_numarasi { get; set; }

        public string durum { get; set; } // 'bos', 'satin_alindi'
    }
}
