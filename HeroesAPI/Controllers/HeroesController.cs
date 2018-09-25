using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HeroesAPI.Interfaces;

namespace PracticeAPI.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : ControllerBase
    {

        private readonly IHeroesService _heroService;

        public HeroesController(IHeroesService heroService)
        {
            _heroService = heroService; 
        }

        // Returns all Hero Models from postgresql database.
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var heroList = await _heroService.GetAllHeroes();
            
            return Ok(heroList);
        }

        // Returns Hero model by primary key id.
        [HttpGet("{id}")]
        public async Task<IActionResult> Id(int id)
        {
            var hero = await _heroService.GetHeroById(id);

            return hero == null ? NotFound("Hero was not found!") : (IActionResult)Ok(hero);
        }

        // Returns Hero model by name.
        [HttpGet("[action]/{name}")]
        public async Task<IActionResult> Name(string name)
        {
            if (name == null) return NotFound("Name can not be null.");

            var hero = await _heroService.GetHeroByName(name);

            return hero == null ? NotFound($"Hero: {name} was not found!") : (IActionResult)Ok(hero);
        }

        // Returns List of all Hero models associated by role.
        [HttpGet("[action]/{role}")]
        public async Task<IActionResult> Role(string role)
        {            
            if (role == null) return NotFound("Role can not be null.");

            var roleList = await _heroService.GetHeroByRole(role);

            return !roleList.Any() ? NotFound($"Role: {role} not found!") : (IActionResult)Ok(roleList);
        }

        // Returns list of all Hero models associated by universe.
        [HttpGet("[action]/{universe}")]
        public async Task<IActionResult> Universe(string universe)
        {
            if (universe == null) return NotFound("Universe can not be null.");

            var universeList = await _heroService.GetHeroByUniverse(universe);

            return !universeList.Any() ? NotFound($"Universe: {universe} not found!") : (IActionResult)Ok(universeList);
        }
    }
}
