using Microsoft.EntityFrameworkCore;
using ColdConnectApp.Models;

namespace ColdConnectApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Abrigo> Abrigos { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
    }
}
