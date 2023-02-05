using Microsoft.EntityFrameworkCore;
using TourOfHeroes_Backend.Models;

namespace TourOfHeroes_Backend.Helpers
{
    public static class DbSeeder
    {
        public static void Seed(ModelBuilder builder)
        {
            Hero hero1 = new Hero()
            {
                HeroId = 1,
                Name = "Spiderman"
            };

            Hero hero2 = new Hero()
            {
                HeroId = 2,
                Name = "Superman"
            };

            Hero hero3 = new Hero()
            {
                HeroId = 3,
                Name = "Ironman"
            };

            Hero hero4 = new Hero()
            {
                HeroId = 4,
                Name = "Electra"
            };

            Hero hero5 = new Hero()
            {
                HeroId = 5,
                Name = "Catwoman"
            };

            Hero hero6 = new Hero()
            {
                HeroId = 6,
                Name = "Thor"
            };

            Hero hero7 = new Hero()
            {
                HeroId = 7,
                Name = "Hulk"
            };

            Hero hero8 = new Hero()
            {
                HeroId = 8,
                Name = "Robin"
            };

            builder.Entity<Hero>().HasData(hero1, hero2, hero3, hero4, hero5, hero6, hero7, hero8);
        }
    }
}
