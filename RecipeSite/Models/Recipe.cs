using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeSite.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 100)]
        public string? Name { get; set; }

  
    }
}
