using Reveries.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reveries
{
    public class Context : DbContext
    {
        public Context() : base("MainDb")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Reverie> Reveries { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Follow> Follows { get; set; }
    }
}