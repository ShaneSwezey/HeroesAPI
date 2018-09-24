using System.ComponentModel.DataAnnotations;

namespace HeroesAPI.Models
{
    public class Hero
    {
        [Required]
        public int HeroId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Role { get; set; }
        public string Universe { get; set; }
    }
}
