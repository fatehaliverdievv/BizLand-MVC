﻿using Microsoft.AspNetCore.Mvc;

namespace bizland.Areas.Manage.Controllers
{
    public class HeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
