using System.Collections.Generic;
using AutoMapper;
using SmartphoneShop.Infrastructure;
using SmartphoneShop.Models;
using SmartphoneShop.Repositories;
using SmartphoneShop.ViewModels;

namespace SmartphoneShop.Services
{
    public class OrderServices
    {
        private readonly OrderRepository _orderRepository = new OrderRepository(new DbFactory());

        public void AddOrder(OrderModel order)
        {
            _orderRepository.Add(order);
            _orderRepository.Save();
        }

        public Mapper MapperInit()
        {
            var config = new MapperConfiguration(cfg => cfg
                .CreateMap<OrderModel, OrderViewModel>());
            var mapper = new Mapper(config);
            return mapper;
        }

        public IEnumerable<OrderViewModel> GetUserOrders(string userId)
        {
            var orders = _orderRepository.GetMany(x => x.UserId == userId);
            return MapperInit().Map<IEnumerable<OrderViewModel>>(orders);
        }
    }
}
