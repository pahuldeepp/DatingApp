using System;
using Microsoft.EntityFrameworkCore;
using API.Entities; // ✅ if your AppUser class is in this namespace

namespace API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
    }
}
