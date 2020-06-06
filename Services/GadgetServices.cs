using System.Collections.Generic;
using SmartphoneShop.Infrastructure;
using SmartphoneShop.Models;
using SmartphoneShop.Repositories;

namespace SmartphoneShop.Services
{
    public class GadgetServices
    {
        private readonly GadgetRepository _gadgetRepository = new GadgetRepository(new DbFactory());

        public IEnumerable<Gadget> GetAll()
        {
            return _gadgetRepository.GetAll();
        }

        public Gadget GetGadget(int id)
        {
            return _gadgetRepository.GetById(id);
        }

        public void AddGadget(Gadget gadget)
        {
            _gadgetRepository.Add(gadget);
            _gadgetRepository.Save();
        }
    }
}
