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
    public class EFaramaDAL : GenericRepository<Arama>,IAramaDAL
    {
        public List<Arama> GetAramaList()
        {
            using (var c = new Context())
            {
                return c.Arama.Include(x => x.AramaTipi).Include(z => z.ArayanTipi)
                    .Include(x => x.Aranan).Include(x => x.Kaydeden).ToList();
            }
        }
    }
}
