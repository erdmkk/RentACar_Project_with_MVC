using Microsoft.EntityFrameworkCore;
using RentACarDataAccess.Abstract;
using RentACarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDataAccess.Concrete
{
    public class CarsDal : Repository<Cars>, ICarsDal
    {
        Context c = new Context();
        public List<Cars> GetCarWithModels(Expression<Func<Cars, bool>> filter = null)
        {
            return c.Cars.Include(x => x.Brand).ToList();
        }
    }
}
