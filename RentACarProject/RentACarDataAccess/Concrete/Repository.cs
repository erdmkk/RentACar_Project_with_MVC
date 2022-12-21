using Microsoft.EntityFrameworkCore;
using RentACarDataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDataAccess.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> set;

        public Repository()
        {
            set = c.Set<T>();
        }


        public int Add(T p)
        {
            set.Add(p);
            return c.SaveChanges();
        }

        public int Delete(T p)
        {
            set.Remove(p);
            return c.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return set.ToList();
        }

        public T GetById(int id)
        {
            return set.Find(id);
        }

        public int Update(T p)
        {
            set.Update(p);
            return c.SaveChanges();
        }
    }
}
