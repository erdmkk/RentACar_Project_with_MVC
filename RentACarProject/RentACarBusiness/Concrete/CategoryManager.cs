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
    public class CategoryManager : ICategoryService
    {
        ICategoriesDal catDal;

        public CategoryManager(ICategoriesDal catDal)
        {
            this.catDal = catDal;
        }

        public int AddCategory(Categories category)
        {
            return catDal.Add(category);
        }

        public int DeleteCategory(Categories category)
        {
            return catDal.Delete(category);
        }

        public List<Categories> GetAllCategories(Expression<Func<Cars, bool>> filter = null)
        {
            return catDal.GetAll();
        }

        public Categories GetCategoryById(int id)
        {
            return catDal.GetById(id);
        }

        public int UpdateCategory(Categories category)
        {
            return catDal.Update(category);
        }
    }
}
