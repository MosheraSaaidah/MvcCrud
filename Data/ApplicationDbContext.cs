
using Microsoft.EntityFrameworkCore;
using MvcCrud.Models;

namespace MvcCrud.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Category> Categorys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MvcCrudDb;TrustServerCertificate=True;Trusted_Connection=True;");
        }
      

    }
}