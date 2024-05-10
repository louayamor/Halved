using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Story
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = String.Empty;

        [Column(TypeName = "ntext")]
        [Required]
        public string Content { get; set; } = String.Empty;

        public string Description { get; set; } = String.Empty;

        public DateTime CreationDate { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public int? AuthorId { get; set; }
        public User? Author { get; set; } 

        public int? GenreId { get; set; }
        public Genre? Genre { get; set; } 

        public required ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public required ICollection<Upvote> Upvotes { get; set; } = new List<Upvote>();
    }
}