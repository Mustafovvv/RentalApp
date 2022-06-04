using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalApp.Controllers
{
    public class CategoriesController : Controller
    {
        [HttpGet]
        public IActionResult Category()
        {
            return View();
        }
    }
}
