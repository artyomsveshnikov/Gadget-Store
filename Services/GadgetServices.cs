using System.Collections.Generic;
using AutoMapper;
using SmartphoneShop.Infrastructure;
using SmartphoneShop.Models;
using SmartphoneShop.Repositories;
using SmartphoneShop.ViewModels;

namespace SmartphoneShop.Services
{
    public class GadgetServices
    {
        private readonly GadgetRepository _gadgetRepository = new GadgetRepository(new DbFactory());

        public IEnumerable<GadgetModel> GetAll()
        {
            return _gadgetRepository.GetAll();
        }

        public GadgetModel GetGadget(int id)
        {
            return _gadgetRepository.GetById(id);
        }

        public void AddGadget(GadgetModel gadgetModel)
        {
            _gadgetRepository.Add(gadgetModel);
            _gadgetRepository.Save();
        }

        public Mapper MapperInit()
        {
            var config = new MapperConfiguration(cfg => cfg
                .CreateMap<GadgetModel, GadgetViewModel>());
            // create automapper instance
            var mapper = new Mapper(config);
            return mapper;
        }


    }
}
