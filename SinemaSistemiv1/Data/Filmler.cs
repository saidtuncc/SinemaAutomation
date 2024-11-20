using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinemaSistemiv1.Data
{
    public class Filmler
    {
        [Key]
        public int film_id { get; set; }

        public string baslik { get; set; }

        public string aciklama { get; set; }

        public int? sure { get; set; }

        public string tur { get; set; }

        public byte[] poster_goruntu { get; set; }

        public float rating { get; set; }

        public ICollection<Seanslar> Seanslar { get; set; } = new List<Seanslar>();
    }
}
