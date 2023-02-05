using TourOfHeroes_Backend.DataContext;
using TourOfHeroes_Backend.Models;
using TourOfHeroes_Backend.Repositories;

namespace TourOfHeroes_Backend.Services
{
    public class HeroService : IHeroService
    {
        private readonly IHeroRepository _heroRepository;
        private readonly Context _dataContext;

        public HeroService(IHeroRepository heroRepository, Context dataContext)
        {
            _heroRepository = heroRepository;
            _dataContext = dataContext;
        }

        public async Task<IEnumerable<Hero>> GetAll()
        {
            return await _heroRepository.GetAll();
        }

        public async Task<Hero> GetById(int id)
        {
            return await _heroRepository.GetById(id);
        }

        public Hero Add(Hero hero)
        {
            if (_heroRepository.Search(b => b.Name == hero.Name).Result.Any())
                return null;

            _heroRepository.Add(hero);
            return hero;
        }

        public async Task<bool> Update(int heroId, string name)
        {
            var heroTemp = await _heroRepository.GetById(heroId);
            heroTemp.Name = name;
            bool result = await _heroRepository.Update(heroTemp);

            if (result)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> Remove(Hero Hero)
        {
            try
            {
                await _heroRepository.Remove(Hero);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<Hero>> Search(string name)
        {

            List<Hero> list = new List<Hero>();
            foreach(var hero in _dataContext.Heroes)
            {
                if(hero.Name.StartsWith(name))
                {
                    list.Add(hero);
                }
            }
            return list;
        }

        public void Dispose()
        {
            _heroRepository?.Dispose();
        }

    }
}
