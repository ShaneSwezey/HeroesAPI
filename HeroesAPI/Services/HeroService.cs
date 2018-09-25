using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HeroesAPI.Interfaces;
using HeroesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HeroesAPI.Services
{
	public class HeroService : IHeroesService
    {
        private readonly HeroApiContext _context;

        public HeroService(HeroApiContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Hero>> GetAllHeroes()
        {
            var heroList = await _context.Heroes
            .OrderBy(h => h.Name).ToListAsync();

            return heroList;
        }

        public async Task<Hero> GetHeroById(int id)
        {
            var hero = await _context.Heroes
            .FirstOrDefaultAsync(h => h.HeroId == id);

            return hero;
        }

        public async Task<Hero> GetHeroByName(string name)
        {
            var hero = await _context.Heroes
            .FirstOrDefaultAsync(h => h.Name
            .Equals(name, StringComparison.InvariantCultureIgnoreCase));

            return hero;
        }

        public async Task<IEnumerable<Hero>> GetHeroByRole(string role)
        {
            var roleList = await _context.Heroes.Where(h =>
            h.Role.Equals(role, StringComparison.InvariantCultureIgnoreCase))
            .OrderBy(n => n.Name)
            .ToListAsync();

            return roleList;
        }

        public async Task<IEnumerable<Hero>> GetHeroByUniverse(string universe)
        {
            var universeList = await _context.Heroes.Where(u =>
            u.Universe.Equals(universe, StringComparison.InvariantCultureIgnoreCase))
            .OrderBy(n => n.Name)
            .ToListAsync();

            return universeList;
        }
    }
}
