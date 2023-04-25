using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Abstract
{
    public interface IGenericService<T> where T : class, new()
    {
        void TInsert(T item);
        void TDelete(T item); 
        void TUpdate(T item);
        List<T> GetListAll();
        T GetById(int id);
    }
}
