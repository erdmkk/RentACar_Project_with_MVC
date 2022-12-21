using RentACarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACarBusiness.Abstract
{
    public interface ICarsService
    {
        int AddCar(Cars car);
        int DeleteCar(Cars car);
        int UpdateCar(Cars car);
        List<Cars> GetAllCars(Expression<Func<Cars, bool>> filter = null);
        List<Cars> GetCarsWithModels(Expression<Func<Cars, bool>> filter = null);
        Cars GetCarById(int id);
    }
}
