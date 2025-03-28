using Microsoft.EntityFrameworkCore;
using Registros.Models;

namespace Registros.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<PersonaModel> Personas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
