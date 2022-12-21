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
    public class CarsManager : ICarsService
    {
        ICarsDal carDal;

        public CarsManager(ICarsDal carDal)
        {
            this.carDal = carDal;
        }

        public int AddCar(Cars car)
        {
            return carDal.Add(car);
        }

        public int DeleteCar(Cars car)
        {
            return carDal.Delete(car);
        }

        public List<Cars> GetAllCars(Expression<Func<Cars, bool>> filter = null)
        {
            return carDal.GetAll();
        }

        public Cars GetCarById(int id)
        {
            return carDal.GetById(id);
        }

        public List<Cars> GetCarsWithModels(Expression<Func<Cars, bool>> filter = null)
        {
            return carDal.GetCarWithModels();
        }

        public int UpdateCar(Cars car)
        {
            return carDal.Update(car);
        }
    }
}
