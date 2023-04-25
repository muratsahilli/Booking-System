using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Arama
    {
        [Key]
        public int AramaId { get; set; }
        public string İsim { get; set; } = null!;
        public string Telefon { get; set; } = null!;
        public string? Konu { get; set; }
        public DateTime AranmaTarihi { get; set; }   
        public int ArayanTipiId { get; set; }
        public int AramaTipiId { get; set; }
        public int KaydedenId { get; set; }
        public int ArananId { get; set; }
        public virtual ArayanTipi ArayanTipi { get; set; } = null!;
        public virtual AramaTipi AramaTipi { get; set; } = null!;
        public virtual AppUser Kaydeden { get; set; } = null!;
        public virtual AppUser Aranan { get; set; } = null!;
    }
}
