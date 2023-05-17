using EprApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EprApi.Data
{
    public class EprApiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=eprdorodrigo.database.windows.net;Database=eprdatabase;User Id=eprdorodrigo;Password=Qq-101010;");
        }

        public DbSet<CatalogProductModel> Product { get; set; }
        public DbSet<Client> Client { get; set; }
    }
}
