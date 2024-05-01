using Microsoft.EntityFrameworkCore;
using SYSTEM_GÁS.Models;

namespace SYSTEM_GÁS.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
