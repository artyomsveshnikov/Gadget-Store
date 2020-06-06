using SmartphoneShop.Infrastructure;
using SmartphoneShop.Models;

namespace SmartphoneShop.Repositories
{
    public class GadgetRepository : RepositoryBase<GadgetModel>
    {
        public GadgetRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
