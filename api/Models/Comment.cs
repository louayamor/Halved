using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int? StoryId { get; set; } 
        public Story? Story { get; set; }
        public int UserId { get; set; } 
        public User? Author { get; set; }
        [Required]
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}