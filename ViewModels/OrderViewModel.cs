using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartphoneShop.Infrastructure;
using SmartphoneShop.Models;
using SmartphoneShop.Repositories;

namespace SmartphoneShop.ViewModels
{
    public class OrderViewModel : OrderModel
    {
        private readonly GadgetRepository _gadgetRepository = new GadgetRepository(new DbFactory());
        public string GadgetName => GetGadgetName();

        private string GetGadgetName()
        {
            if (GadgetId == null)
                throw new InvalidOperationException("Gadget Id cannot be null");

            return _gadgetRepository.GetById((int)GadgetId).Name;
        }

    }
}
