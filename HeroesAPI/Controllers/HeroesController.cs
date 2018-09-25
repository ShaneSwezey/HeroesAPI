using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HeroesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace PracticeAPI.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : ControllerBase
    {
        // DbContext
        private readonly HeroApiContext context;

        public HeroesController(HeroApiContext context)
        {
            this.context = context; 
        }

        // Returns all Hero Models from postgresql database.
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var heroList =  await context.Heroes.OrderBy(n => n.Name)
            .ToListAsync();
            
            return Ok(heroList);
        }

        // Returns Hero model by primary key id.
        [HttpGet("{id}")]
        public async Task<IActionResult> Id(int id)
        {
            var hero = await context.Heroes
            .FirstOrDefaultAsync(h => h.HeroId == id);
            
            if (hero == null) return NotFound("Hero was not found!");

            return Ok(hero);
        }

        // Returns Hero model by name.
        [HttpGet("[action]/{name}")]
        public async Task<IActionResult> Name(string name)
        {
            if (name == null) return NotFound("Name can not be null.");

            var hero = await context.Heroes
            .FirstOrDefaultAsync(h => h.Name
            .Equals(name, StringComparison.InvariantCultureIgnoreCase));

            if (hero == null) return NotFound($"Hero: {name} was not found!");

            return Ok(hero);
        }

        // Returns List of all Hero models associated by role.
        [HttpGet("[action]/{role}")]
        public async Task<IActionResult> Role(string role)
        {            
            if (role == null) return NotFound("Role can not be null.");

            var roleList = await context.Heroes.Where(h => 
            h.Role.Equals(role, StringComparison.InvariantCultureIgnoreCase))
            .OrderBy(n => n.Name)
            .ToListAsync();

            if (roleList.Count == 0) return NotFound($"Role: {role} not found!");

            return Ok(roleList);
        }

        // Returns list of all Hero models associated by universe.
        [HttpGet("[action]/{universe}")]
        public async Task<IActionResult> Universe(string universe)
        {
            if (universe == null) return NotFound("Universe can not be null.");

            var universeList = await context.Heroes.Where(u =>
            u.Universe.Equals(universe, StringComparison.InvariantCultureIgnoreCase))
            .OrderBy(n => n.Name)
            .ToListAsync();

            if (universeList.Count == 0) return NotFound($"Universe: {universe} not found!");

            return Ok(universeList);
        }
    }
}
