using DesafioLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace DesafioLibrary.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        public DbSet<Obras> Obras { get; set; }  
    }
}
