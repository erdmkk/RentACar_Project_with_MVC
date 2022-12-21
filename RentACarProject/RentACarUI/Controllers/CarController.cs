using Microsoft.AspNetCore.Mvc;
using RentACarBusiness.Abstract;
using RentACarUI.Models;

namespace RentACarUI.Controllers
{
    public class CarController : Controller
    {
        ICarsService carService;

        public CarController(ICarsService carService)
        {
            this.carService = carService;
        }   

        public IActionResult Index()
        {
            CarViewModel model = new CarViewModel
            {
                Cars = carService.GetCarsWithModels()
            };
            return View(model);
        }
    }
}
