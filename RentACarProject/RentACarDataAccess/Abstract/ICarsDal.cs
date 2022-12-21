using RentACarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDataAccess.Abstract
{
    public interface ICarsDal : IRepository<Cars>
    {
        public List<Cars> GetCarWithModels(Expression<Func<Cars, bool>> filter = null);
    }
}
