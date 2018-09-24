using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeroesAPI.Models
{
    public class HeroStats
    {
        [Range(1, 10, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Damage { get; set; }
        [Range(1, 10, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Utility { get; set; }
        [Range(1, 10, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Survivability { get; set; }
        [Range(1, 10, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Complexity { get; set; }

        [ForeignKey("Hero")]
        public int HeroRefId { get; set; }
        public Hero Hero { get; set; }
    }
}
