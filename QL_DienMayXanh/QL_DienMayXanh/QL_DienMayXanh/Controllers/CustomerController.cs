using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL_DienMayXanh.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CustomerHome()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
    }
}
