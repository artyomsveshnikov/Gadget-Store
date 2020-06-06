using SmartphoneShop.Infrastructure;
using SmartphoneShop.Models;
using SmartphoneShop.Repositories;

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
    }
}
