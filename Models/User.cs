using Microsoft.AspNetCore.Identity;

namespace SmartphoneShop.Models
{
    public class User: IdentityUser
    {
        public int Year { get; set; }
    }
}
