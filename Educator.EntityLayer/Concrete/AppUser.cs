using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Edukator.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? City { get; set; }

        [StringLength(100)]
        public string? ImageURL { get; set; }
    }
}
