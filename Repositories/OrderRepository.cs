using SmartphoneShop.Infrastructure;
using SmartphoneShop.Models;

namespace SmartphoneShop.Repositories
{
    public class OrderRepository : RepositoryBase<OrderModel>
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
