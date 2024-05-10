using System;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public required string Username { get; set; }

        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
