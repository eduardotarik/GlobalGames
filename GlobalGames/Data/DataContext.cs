using GlobalGames.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GlobalGames.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Subscriber> Subscribers { get; set; }

        public DbSet<Budget> Budgets { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
