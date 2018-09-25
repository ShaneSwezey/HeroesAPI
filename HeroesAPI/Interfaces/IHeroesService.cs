using System;
using System.Collections.Generic;
using HeroesAPI.Models;

namespace HeroesAPI.Interfaces
{
    public interface IHeroesService
    {
        IEnumerable<Hero> GetAllHeroes();
        Hero GetHeroById();
        Hero GetHeroByName(string name);
        Hero GetHeroByRole(string role);
        Hero GetHeroByUniverse(string universe);
    }
}
