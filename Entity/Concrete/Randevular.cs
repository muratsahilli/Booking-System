using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class Randevular
    {
        [Key]
        public int RandevuId { get; set; }        
        public string RandevuyaGelen { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public DateTime StartTime { get; set; } 
        public DateTime EndTime { get; set; }
        public string Konu { get; set; } = null!;
        public int RandevuDurumuId { get; set; }
        public int RandevuKaydedenId { get; set; }
        public int ZiyaretEdilenKisiId { get; set; }
        public virtual RandevuDurumu RandevuDurumu { get; set; } = null!;
        public virtual AppUser RandevuKaydeden { get; set; } = null!;
        public virtual AppUser ZiyaretEdilenKisi { get; set; } = null!;


    }
}
