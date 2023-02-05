using Microsoft.EntityFrameworkCore;
using TourOfHeroes_Backend.Helpers;
using TourOfHeroes_Backend.Models;

namespace TourOfHeroes_Backend.DataContext
{
    public class Context : DbContext
    {
        public Context
            (DbContextOptions<Context> options) : base(options) { }

        public DbSet<Hero>? Heroes { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            DbSeeder.Seed(builder);
        }

    }
}
