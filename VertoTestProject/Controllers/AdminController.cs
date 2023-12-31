﻿//Controller for admin views
using Microsoft.AspNetCore.Mvc;
using VertoTestProject.Models;
using VertoTestProject.Services;

namespace VertoTestProject.Controllers
{
    public class AdminController : Controller
    {
        //Create an instance of the ContentService
        private readonly ContentService _service;

        //Define a list to store the contents
        public IList<Content> ContentList { get; set; } = default!;

        //Content object ContentItem that stores singular item requested for editing

        [BindProperty]
        public Content ContentItem { get; set; } = default!;

        //Content object that stores the updated content of a component

        [BindProperty]
        public Content UpdateContent { get; set; } = default!;

        //Inject the ContentService into the controller
        public AdminController(ContentService service)
        {
            _service = service;
        }

        //Method which runs when index page is requested
        public IActionResult Index()
        {
            IList<Content> ContentList = _service.GetContent();

            return View(ContentList);
        }

        //Method that runs when Edit page is requested
        public IActionResult Edit(int id)
        {
            ContentItem = _service.GetContentById(id);
            
            //ViewData["id"] = id;
            return View(ContentItem);
        }


    }
}
