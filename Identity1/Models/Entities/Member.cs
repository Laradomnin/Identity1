using Microsoft.AspNetCore.Identity;

namespace Identity1.Models.Entities
{
    public class Member:IdentityUser
    {
        public bool IsPro { get; set; } 
        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
