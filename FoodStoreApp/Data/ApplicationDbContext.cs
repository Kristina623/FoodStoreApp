
using FoodStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FoodStoreApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Category { get; set; }
    }
}
