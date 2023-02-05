using TourOfHeroes_Backend.DataContext;
using TourOfHeroes_Backend.Models;

namespace TourOfHeroes_Backend.Repositories
{
    public class HeroRepository : Repository<Hero>, IHeroRepository
    {
        public HeroRepository(Context context) : base(context) { }
    }
}
