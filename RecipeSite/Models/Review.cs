using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeSite.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int? RecipeId { get; set; }
        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }

        public string? User_Id { get; set; }
       
        [ForeignKey("User_Id")]
        public ApplicationUser ApplicationUser { get; set; }

        public string? createdBy { get; set; }

        public decimal? rating { get; set; }
        
        public string? content { get; set; }

        public DateTime CreatedDate { get; set; }


    }
}
