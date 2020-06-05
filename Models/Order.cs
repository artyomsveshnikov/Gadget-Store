using System.Collections.Generic;

namespace SmartphoneShop.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int GadgetId { get; set; }
        public string UserId { get; set; }
    }
}
