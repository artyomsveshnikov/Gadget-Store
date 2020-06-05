using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SmartphoneShop.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult GadgetList()
        {
            return View();
        }
    }
}