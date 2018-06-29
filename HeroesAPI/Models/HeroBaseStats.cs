using System;
namespace PracticeAPI.Models
{
    public class HeroBaseStats
    {
        public int Health { get; set; }
        public decimal HealthRegen { get; set; }
        public int Mana { get; set; }
        public decimal ManaRegen { get; set; }
        public decimal AttackSpeed { get; set; }
        public int Damage { get; set; }
        public int HeroId { get; set; }
    }
}
