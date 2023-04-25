using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entity.Concrete
{
    public class ArayanTipi
    {
        
        [Key]
        public int ArayanTipiId { get; set; }
        public string Arayantipi { get; set; } 
        public List<Arama> Aramalar { get; set; }
    }
}
