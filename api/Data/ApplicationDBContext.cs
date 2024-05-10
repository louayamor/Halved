using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Story> Story { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Genre> Genre { get; set; }
        //public DbSet<Message> Massage { get; set; }
        public DbSet<Upvote> Upvote { get; set; }
        public DbSet<User> User { get; set; }
    }
}