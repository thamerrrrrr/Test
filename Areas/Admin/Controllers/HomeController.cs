﻿using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_MVC.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {

            return View();
        }
    }
}
