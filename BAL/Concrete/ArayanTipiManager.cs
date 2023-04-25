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
    public class ArayanTipiManager : IGenericService<ArayanTipi>
    {
        IArayanTipiDAL _arayanTipiDAL;

        public ArayanTipiManager(IArayanTipiDAL arayanTipiDAL)
        {
            _arayanTipiDAL = arayanTipiDAL;
        }

        public ArayanTipi GetById(int id)
        {
            return _arayanTipiDAL.GetByID(id);
        }

        public List<ArayanTipi> GetListAll()
        {
            return _arayanTipiDAL.GetListAll();
        }

        public void TDelete(ArayanTipi item)
        {
            _arayanTipiDAL.Delete(item);
        }

        public void TInsert(ArayanTipi item)
        {
            _arayanTipiDAL.Insert(item);
        }

        public void TUpdate(ArayanTipi item)
        {
            _arayanTipiDAL.Update(item);
        }
    }
}
