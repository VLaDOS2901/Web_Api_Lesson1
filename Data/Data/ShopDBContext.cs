using Microsoft.EntityFrameworkCore;
using Data.Models;
using Data.Mock;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Data
{
    public class ShopDbContext : IdentityDbContext
    {
        public ShopDbContext() { }
        public ShopDbContext(DbContextOptions options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MonitorsApiDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Matrix>().HasData(MockData.GetMatrix());
            modelBuilder.Entity<Models.Monitor>().HasData(MockData.GetMonitors());
        }

        public DbSet<Matrix> Matrixes { get; set; }
        public DbSet<Models.Monitor> Monitors { get; set; }
    }
}
