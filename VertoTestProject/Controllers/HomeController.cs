//First controller will go here

using Microsoft.AspNetCore.Mvc;

using VertoTestProject.Models;
using VertoTestProject.Services;


namespace VertoTestProject.Controllers
{
    public class HomeController : Controller
    {
        //Create an instance of the ContentService
        private readonly ContentService _service;

        //Define a list to store the contents
        public IList<Content> ContentList { get; set; } = default!;

        //Inject the ContentService into the controller
        public HomeController(ContentService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            ContentList = _service.GetContent();

            return View(ContentList);
        }

        public IActionResult Cms()
        {
            return View();
        }
    }
}
