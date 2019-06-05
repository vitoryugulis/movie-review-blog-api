using System;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{
    public class BlogContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../Repository/LocalDatabase/blog.db");
        }
    }
}