using BAL.Abstract;
using DAL.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Concrete
{
    public class RandevuDurumuManager : IGenericService<RandevuDurumu>
    {
        IRandevuDurumuDAL randevuDurumuDAL;

        public RandevuDurumuManager(IRandevuDurumuDAL randevuDurumuDAL)
        {
            this.randevuDurumuDAL = randevuDurumuDAL;
        }

        public RandevuDurumu GetById(int id)
        {
            return randevuDurumuDAL.GetByID(id);
        }

        public List<RandevuDurumu> GetListAll()
        {
            return randevuDurumuDAL.GetListAll();
        }

        public void TDelete(RandevuDurumu item)
        {
            randevuDurumuDAL.Delete(item);
        }

        public void TInsert(RandevuDurumu item)
        {
           randevuDurumuDAL.Insert(item);
        }

        public void TUpdate(RandevuDurumu item)
        {
            randevuDurumuDAL.Update(item);
        }
    }
}
