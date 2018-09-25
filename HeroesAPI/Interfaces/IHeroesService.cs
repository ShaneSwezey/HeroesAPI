using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HeroesAPI.Models;

namespace HeroesAPI.Interfaces
{
    public interface IHeroesService
    {
        Task<IEnumerable<Hero>> GetAllHeroes();
        Task<Hero> GetHeroById(int id);
        Task<Hero> GetHeroByName(string name);
        Task<IEnumerable<Hero>> GetHeroByRole(string role);
        Task<IEnumerable<Hero>> GetHeroByUniverse(string universe);
    }
}
