using System.ComponentModel.DataAnnotations;

namespace TourOfHeroes_Backend.Models
{
    public class Hero : Entity
    {
        
        [Required]
        public string Name { get; set; }
    }
}
