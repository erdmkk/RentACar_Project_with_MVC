using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        int Add(T p);
        int Update(T p);
        int Delete(T p);
        T GetById(int id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
