using System;

namespace api.Models
{
    public class Upvote
    {
        public int Id { get; set; }
        
        public int UserId { get; set; } 
        public User User { get; set; } 

        public int? StoryId { get; set; } 
        public Story Story { get; set; } 

        public int? CommentId { get; set; } 
        public Comment Comment { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
