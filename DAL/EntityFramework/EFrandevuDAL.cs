using DAL.Abstract;
using DAL.Concrete;
using DAL.Repository;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EntityFramework
{
    public class EFrandevuDAL : GenericRepository<Randevular>, IRandevuDAL
    {
        public List<Randevular> GetRandevuList()
        {
            using (var c = new Context())
            {
                return c.Randevu.Include(x => x.RandevuDurumu).Include(z => z.RandevuKaydeden)
                    .Include(x => x.ZiyaretEdilenKisi).ToList();
            }
        }
    }
}
 