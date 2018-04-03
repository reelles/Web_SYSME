using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebSysme.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult ProductsGrid()
        {
            return View();
        }
    }
}