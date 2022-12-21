using RentACarBusiness.Abstract;
using RentACarDataAccess.Abstract;
using RentACarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarBusiness.Concrete
{
    public class BrandsManager : IBrandsService
    {
        IBrandsDal brandDal;

        public BrandsManager(IBrandsDal brandDal)
        {
            this.brandDal = brandDal;
        }

        public int AddBrand(Brands brand)
        {
            return brandDal.Add(brand);
        }

        public int DeleteBrand(Brands brand)
        {
            return brandDal.Delete(brand);
        }

        public List<Brands> GetAllBrands(Expression<Func<Brands, bool>> filter = null)
        {
            return brandDal.GetAll();
        }

        public Brands GetBrandById(int id)
        {
            return brandDal.GetById(id);
        }

        public int UpdateBrand(Brands brand)
        {
            return brandDal.Update(brand);
        }
    }
}
