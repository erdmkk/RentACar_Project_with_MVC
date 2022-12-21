using RentACarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarBusiness.Abstract
{
    public interface ICategoryService
    {
        int AddCategory(Categories category);
        int UpdateCategory(Categories category);    
        int DeleteCategory(Categories category);
        List<Categories> GetAllCategories(Expression<Func<Cars, bool>> filter = null);
        Categories GetCategoryById(int id);
    }
}
