using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HeroesAPI.Models;

namespace HeroesAPI.Interfaces
{
    public interface IHeroesService
    {
        Task<IEnumerable<Hero>> GetAllHeroes();
        Task<Hero> GetHeroById();
        Task<Hero> GetHeroByName(string name);
        Task<Hero> GetHeroByRole(string role);
        Task<Hero> GetHeroByUniverse(string universe);
    }
}
