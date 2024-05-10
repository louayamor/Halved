using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        public required string Description { get; set; }

        public ICollection<Story> Stories { get; set; } = new List<Story>();
    }
}
