using RecipeSite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace RecipeSite.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().HasMany(c => c.Recipes).WithOne(c => c.ApplicationUser).OnDelete(DeleteBehavior.Restrict); ;

            builder.Entity<ApplicationUser>().HasMany(c => c.Reviews).WithOne(c => c.ApplicationUser).OnDelete(DeleteBehavior.Restrict); ;

            builder.Entity<Recipe>().HasMany(c => c.Reviews).WithOne(c => c.Recipe);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Recipe> Recipes { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}
