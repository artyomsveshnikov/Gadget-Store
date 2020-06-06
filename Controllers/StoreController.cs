using System.Collections.Generic;
using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartphoneShop.Models;
using SmartphoneShop.Services;
using SmartphoneShop.ViewModels;

namespace SmartphoneShop.Controllers
{
    public class StoreController : Controller
    {
        private readonly GadgetServices _gadgetServices = new GadgetServices();
        private readonly OrderServices _orderServices = new OrderServices();
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
            HttpContext.Session.SetInt32("GadgetId", gadgetId);
            return View(_mapper.Map<GadgetViewModel>(gadget));
        }

        [HttpPost]
        public IActionResult Order(IFormCollection collection)
        {
            var id = HttpContext.Session.GetInt32("GadgetId");
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var address = collection["Address"].ToString();
            var phone = collection["PhoneNumber"].ToString();

            _orderServices.AddOrder(
                new OrderModel
                {
                    GadgetId = id,
                    UserId = userId,
                    Address = address,
                    PhoneNumber = phone
                });

            return RedirectToAction("GadgetList", "Store");
        }

        [HttpGet]
        public IActionResult UserCart()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View(_orderServices.GetUserOrders(userId));
        }
    }
}