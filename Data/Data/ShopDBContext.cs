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

   //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   //     {
   //         base.OnConfiguring(optionsBuilder);
   //         string connStr = "Server=tcp:testserver121212.database.windows.net,1433;Initial Catalog=monitors_db;Persist Security Info=False;User ID=CloudSAdc4edef1;Password=GEnius29012017;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
			//optionsBuilder.UseSqlServer(connStr);
   //     }
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
