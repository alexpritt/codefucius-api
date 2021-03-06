using codefucius_api.Models;
using Microsoft.EntityFrameworkCore;

namespace codefucius_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Feedback> Feedback { get; set; }
    }
}
