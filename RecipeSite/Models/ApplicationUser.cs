using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeSite.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? AccountUsername { get; set; }

        public string? Email { get; set; }

        public List<Recipe>? Recipes { get; set; }

        public List<Review>? Reviews { get; set; }
   
    }
}
