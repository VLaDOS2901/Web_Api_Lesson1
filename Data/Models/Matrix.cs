using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class Matrix
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Monitor> Monitors { get; set; }
        
    }
}
