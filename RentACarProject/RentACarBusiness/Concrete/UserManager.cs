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
    public class UserManager : IUserService
    {
        IUsersDal userDal;

        public UserManager(IUsersDal userDal)
        {
            this.userDal = userDal;
        }

        public int AddUser(Users user)
        {
            return userDal.Add(user);
        }

        public int DeleteUser(Users user)
        {
            return userDal.Delete(user);
        }

        public List<Users> GetAllUser(Expression<Func<Users, bool>> filter = null)
        {
            return userDal.GetAll();
        }

        public Users GetUserById(int id)
        {
            return userDal.GetById(id);
        }

        public int UpdateUser(Users user)
        {
            return userDal.Update(user);
        }
    }
}
