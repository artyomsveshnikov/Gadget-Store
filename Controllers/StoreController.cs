using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmartphoneShop.Services;

namespace SmartphoneShop.Controllers
{
    public class StoreController : Controller
    {
        private readonly GadgetServices _gadgetServices = new GadgetServices();

        [HttpGet]
        public IActionResult GadgetList()
        {
            return View(_gadgetServices.GetAll());
        }
    }
}