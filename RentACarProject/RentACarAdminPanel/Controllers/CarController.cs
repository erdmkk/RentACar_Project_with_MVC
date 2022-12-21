using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update;
using RentACarBusiness.Abstract;
using RentACarBusiness.Validations;
using RentACarDataAccess;
using RentACarEntities.Concrete;
using System.Linq;

namespace RentACarAdminPanel.Controllers
{
    public class CarController : Controller
    {
        Context c = new Context();

        ICarsService carService;

        public CarController(ICarsService carService)
        {
            this.carService = carService;
        }

        //GET ALL

        [Authorize(Roles = "admin")]
        public IActionResult GetAll()
        {
            var result = carService.GetCarsWithModels();
            return View(result);
        }

        //ADD CAR

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Cars car)
        {
            CarsValidationRules carValidator = new CarsValidationRules();
            ValidationResult result = carValidator.Validate(car);

            if (result.IsValid)
            {
                carService.AddCar(car);
                return RedirectToAction("GetAll");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        //UPDATE CAR

        public IActionResult Update(int id)
        {
            var result = carService.GetCarById(id);
            return View(result);
        }

        [HttpPost]
        public IActionResult Update(Cars car)
        {
            CarsValidationRules carValidator = new CarsValidationRules();
            ValidationResult result = carValidator.Validate(car);
            if (result.IsValid)
            {
                carService.UpdateCar(car);
                return RedirectToAction("GetAll");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        //DELETE CAR

        public IActionResult Delete(int id)
        {
            var result = c.Cars.FirstOrDefault(x => x.carID == id);
            carService.DeleteCar(result);
            return RedirectToAction("GetAll");
        }
    }
}
