namespace OdeToFood.Data
{
    using Microsoft.EntityFrameworkCore;

    using OdeToFood.Models;

    public class OdeToFoodDbContext : DbContext
    {
        public OdeToFoodDbContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
