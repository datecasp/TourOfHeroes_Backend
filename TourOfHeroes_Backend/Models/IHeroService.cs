namespace TourOfHeroes_Backend.Models
{
    public interface IHeroService
    {
        Task<IEnumerable<Hero>> GetAll();
        Task<Hero> GetById(int id);
        Hero Add(Hero hero);
        Task<bool> Update(int heroId, string name);
        Task<bool> Remove(Hero hero);
        Task<IEnumerable<Hero>> Search(string name);
    }
}

