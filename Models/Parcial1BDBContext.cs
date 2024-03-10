using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace PARCIAL1B.Models
{
    public class Parcial1BDBContext : DbContext
    {

        public Parcial1BDBContext(DbContextOptions<Parcial1BDBContext> options) : base(options)
        {

        }

        public DbSet<Elementos> Elementos { get; set; }
        public DbSet<ElementosPorPlato> ElementosPorPlato { get; set; }
        public DbSet<Platos> Platos { get; set; }
        public DbSet<PlatosPorCombo> PlatosPorCombo { get; set; }

    }
}
