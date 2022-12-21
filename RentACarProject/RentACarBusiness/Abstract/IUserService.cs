using RentACarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarBusiness.Abstract
{
    public interface IUserService
    {
        int AddUser(Users user);
        int DeleteUser(Users user);
        int UpdateUser(Users user);
        List<Users> GetAllUser(Expression<Func<Users, bool>> filter = null);
        Users GetUserById(int id);
    }
}
