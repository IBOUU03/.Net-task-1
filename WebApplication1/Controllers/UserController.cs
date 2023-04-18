﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ContentResult Detail(int id) 
        {
            return Content(id.ToString());
        }
    }
}
