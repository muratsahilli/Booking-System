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
    public class RandevuManager : IGenericService<Randevular>
    {
        private readonly IRandevuDAL _randevuDal;

        public RandevuManager(IRandevuDAL randevuDal)
        {
            _randevuDal = randevuDal;
        }

        public Randevular GetById(int id)
        {
            return _randevuDal.GetByID(id);
        }

        public List<Randevular> GetListAll()
        {
            return _randevuDal.GetRandevuList();
        }

        public void TDelete(Randevular item)
        {
            _randevuDal.Delete(item);
        }

        public void TInsert(Randevular item)
        {
            _randevuDal.Insert(item);
        }

        public void TUpdate(Randevular item)
        {
            _randevuDal.Update(item);
        }
    }
}
