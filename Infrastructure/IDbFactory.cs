using SmartphoneShop.Data;

namespace SmartphoneShop.Infrastructure
{
    public interface IDbFactory
    {
        GadgetStoreContext Init();
    }
}
