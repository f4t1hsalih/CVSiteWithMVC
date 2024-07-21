using CVSiteWithMVC.Models.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CVSiteWithMVC.Repositories
{
    public class GenericRepository<T> where T : class
    {
        CVSiteWithMVCEntities db = new CVSiteWithMVCEntities();

        public void TInsert(T t)
        {
            db.Set<T>().Add(t);
            db.SaveChanges();
        }
        public void TUpdate(T t)
        {
            db.SaveChanges();
        }
        public void TDelete(T t)
        {
            db.Set<T>().Remove(t);
            db.SaveChanges();
        }
        public List<T> TGetListAll()
        {
            return db.Set<T>().ToList();
        }

        public T TGetById(int id)
        {
            return db.Set<T>().Find(id);
        }
        public T TFind(Expression<System.Func<T, bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }

    }
}