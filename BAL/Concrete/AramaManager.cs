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
    public class AramaManager : IGenericService<Arama>
    {

        IAramaDAL _aramaDal;

        public AramaManager(IAramaDAL aramaDal)
        {
            _aramaDal = aramaDal;
        }

        public Arama GetById(int id)
        {
            return _aramaDal.GetByID(id);
        }

        public List<Arama> GetListAll()
        {
            return _aramaDal.GetAramaList();
        }

        public void TInsert(Arama item)
        {
            _aramaDal.Insert(item);
        }

        public void TDelete(Arama item)
        {
            _aramaDal.Delete(item);
        }

        public void TUpdate(Arama item)
        {
            _aramaDal.Update(item);
        }
    }
}
