using SmartphoneShop.Infrastructure;
using SmartphoneShop.Models;

namespace SmartphoneShop.Repositories
{
    public class GadgetRepository : RepositoryBase<Gadget>
    {
        public GadgetRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
