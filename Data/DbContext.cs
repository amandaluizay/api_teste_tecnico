using Microsoft.EntityFrameworkCore;
using TesteTecnicoV.Models;

namespace TesteTecnicoV.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=DB_TesteTecnicoV;User ID=sa;Password=1q2w3e4r@#$");
        }


    }
}