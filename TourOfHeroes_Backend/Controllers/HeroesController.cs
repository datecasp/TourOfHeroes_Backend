using Microsoft.AspNetCore.Mvc;
using TourOfHeroes_Backend.DataContext;
using TourOfHeroes_Backend.Models;

namespace TourOfHeroes_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroesController : ControllerBase
    {
        private readonly Context _context;
        private readonly IHeroService _heroService;

        public HeroesController(Context context, IHeroService heroService)
        {
            _context = context;
            _heroService = heroService;
        }

        // GET: api/<HeroesController>
        [HttpGet]
        public async Task<IEnumerable<Hero>> GetHero()
        {
            return await _heroService.GetAll();
        }

        // GET api/<HeroesController>/5
        [HttpGet("{id}")]
        public async Task<Hero> GetHeroById(int id)
        {
            return await _heroService.GetById(id);
        }

        // GET api/<HeroesController>/5
        [HttpGet("SearchByName/{name}")]
        public async Task<IEnumerable<Hero>> Search(string name)
        {
            return await _heroService.Search(name);
        }

        // POST api/<HeroesController>
        [HttpPost]
        public void Post([FromBody] Hero hero)
        {
            _heroService.Add(hero);
        }

        // PUT api/<HeroesController>/5
        [HttpPut("{id}")]
        public async Task<bool> Put(int id, [FromBody] Hero hero)
        {
            return await _heroService.Update(id, hero.Name);
        }

        // DELETE api/<HeroesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            Hero heroTemp = await GetHeroById(id);
            bool isDeleted = await _heroService.Remove(heroTemp);
            return Ok($"Book {id} removed");

        }
    }
}
