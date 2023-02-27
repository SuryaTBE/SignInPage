using Microsoft.AspNetCore.Mvc;
using SignInPage.Models;

namespace SignInPage.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInContext sc;
        public LoginController(SignInContext _sc)
        {
            sc=_sc;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User u)
        {
            sc.Usertbl.Add(u);
            sc.SaveChanges();
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User u)
        {
            var result = (from i in sc.Usertbl
                          where i.email == u.email && i.password == u.password
                          select i).SingleOrDefault();
            if(result!=null)
            {
                return Redirect("Success");
            }
            else
            {
                ViewBag.message = "Enter valid e-mail and password...";
                return View();
            }
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
