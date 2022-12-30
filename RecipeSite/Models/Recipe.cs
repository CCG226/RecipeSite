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
        public string? title { get; set; }

        public string? description { get; set; }

        public string? equipment { get; set; }

        public string? tags { get; set; }

        public string? instructionSteps { get; set; }

        public string? ingredients { get; set; }

        public string? images { get; set; }

        public decimal rating { get; set; }

        public string? createdBy { get; set; }
    }
}
