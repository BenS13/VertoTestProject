//First controller will go here
using VertoTestProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace VertoTestProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cms()
        {
            return View();
        }
    }
}
