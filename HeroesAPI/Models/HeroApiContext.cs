using System;
using Microsoft.EntityFrameworkCore;
using HeroesAPI.Models;

namespace HeroesAPI.Models
{
    public class HeroApiContext : DbContext
    {
        public HeroApiContext(DbContextOptions<HeroApiContext> options)
            : base(options) { }

        public DbSet<Hero> Heroes {get; set;}
    }
}
