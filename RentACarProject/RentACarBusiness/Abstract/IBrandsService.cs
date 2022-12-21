using RentACarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarBusiness.Abstract
{
    public interface IBrandsService
    {
        int AddBrand(Brands brand);
        int UpdateBrand(Brands brand);
        int DeleteBrand(Brands brand);
        List<Brands> GetAllBrands(Expression<Func<Brands, bool>> filter = null);
        Brands GetBrandById(int id);
    }
}
