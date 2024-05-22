using ControleDeMembros.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeMembros.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<MembroModel> Membros { get; set; }
    }
}
