using CVSiteWithMVC.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace CVSiteWithMVC.Repositories
{
    public class GenericRepository<T> where T : class
    {
        CVSiteWithMVCEntities db = new CVSiteWithMVCEntities();

        public void Insert(T t)
        {
            db.Set<T>().Add(t);
            db.SaveChanges();
        }
        public void Update(T t)
        {
            db.SaveChanges();
        }
        public void Delete(T t)
        {
            db.Set<T>().Remove(t);
            db.SaveChanges();
        }
        public List<T> GetListAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

    }
}