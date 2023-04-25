using DAL.Abstract;
using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class GenericRepository<T>:IGenericDAL<T> where T : class, new()
    {
        public void Delete(T item)
        {
            using var c = new Context();
            c.Remove(item);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();

        }

        public void Insert(T item)
        {
            using var c = new Context();
            c.Add(item);
            c.SaveChanges();  //bu satırda sorun var
        }

        public void Update(T item)
        {
            using var c = new Context();
            c.Update(item);
            c.SaveChanges();
        }
    }
}
