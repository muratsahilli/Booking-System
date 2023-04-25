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
    public class AramaTipiManager : IGenericService<AramaTipi>
    {
        IAramaTipiDAL _aramatipiDal;

        public AramaTipiManager(IAramaTipiDAL aramatipiDal)
        {
            _aramatipiDal = aramatipiDal;
        }

        public AramaTipi GetById(int id)
        {
            return _aramatipiDal.GetByID(id); ;
        }

        public List<AramaTipi> GetListAll()
        {
            return _aramatipiDal.GetListAll();
        }

        public void TDelete(AramaTipi item)
        {
            _aramatipiDal.Delete(item);
        }

        public void TInsert(AramaTipi item)
        {
            _aramatipiDal.Insert(item);
        }

        public void TUpdate(AramaTipi item)
        {
            _aramatipiDal.Update(item);
        }
    }
}
