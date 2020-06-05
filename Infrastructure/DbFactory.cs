using SmartphoneShop.Data;

namespace SmartphoneShop.Infrastructure
{
    public class DbFactory : IDbFactory
    {
        public GadgetStoreContext Init()
        {
            return new GadgetStoreContext();
        }
    }
}
