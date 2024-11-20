using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSistemiv1.Data
{
    public class HalkGunu
    {
        [Key]
        public int id { get; set; }
        public string gun { get; set; }
        public decimal fiyat { get; set; } 
    }
}
