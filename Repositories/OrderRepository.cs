using SmartphoneShop.Infrastructure;
using SmartphoneShop.Models;

namespace SmartphoneShop.Repositories
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
