using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using RentACarBusiness.Abstract;
using RentACarDataAccess;
using RentACarEntities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RentACarAdminPanel.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();

        private readonly IUserService userService;
        public LoginController(IUserService userService)
        {
            this.userService = userService;
        }

        //LOGIN

        public IActionResult Login(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Users user)
        {
            var values = c.Users.FirstOrDefault(x => x.userEmail == user.userEmail && x.password == user.password);
            if(values != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, values.userEmail),
                    new Claim(ClaimTypes.Role, values.userRole)
                };

                var identity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(principal);


                if (TempData["returnUrl"] != null)
                {
                    if (Url.IsLocalUrl(TempData["returnUrl"].ToString()))
                    {
                        return Redirect(TempData["returnUrl"].ToString());
                    }
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        //LOG OUT

        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Login");
        }

        //CREATE ACCOUNT

        public IActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(Users user)
        {
            userService.AddUser(user);
            return RedirectToAction("Login");
        }

        //INDEX
        public IActionResult Index()
        {
            return View();
        }
    }
}
