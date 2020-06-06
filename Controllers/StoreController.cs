using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmartphoneShop.Models;
using SmartphoneShop.Services;
using SmartphoneShop.ViewModels;

namespace SmartphoneShop.Controllers
{
    public class StoreController : Controller
    {
        private readonly GadgetServices _gadgetServices = new GadgetServices();
        private readonly Mapper _mapper;

        public StoreController()
        {
            _mapper = _gadgetServices.MapperInit();
        }

        [HttpGet]
        public IActionResult GadgetList()
        {
            var gadgets = _gadgetServices.GetAll();
            var model = _mapper.Map<IEnumerable<GadgetViewModel>>(gadgets);
            return View(model);
        }

        [HttpGet]
        public IActionResult Order(int gadgetId)
        {
            var gadget = _gadgetServices.GetGadget(gadgetId);
            return View(_mapper.Map<GadgetViewModel>(gadget));
        }
    }
}