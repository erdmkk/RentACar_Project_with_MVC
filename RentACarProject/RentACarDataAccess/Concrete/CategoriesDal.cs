using RentACarDataAccess.Abstract;
using RentACarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDataAccess.Concrete
{
    public class CategoriesDal : Repository<Categories> , ICategoriesDal
    {
    }
}
