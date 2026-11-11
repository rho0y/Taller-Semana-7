using System.Data.Entity;

namespace ApiDigimon.Models
{
    public class DigimonContext : DbContext
    {
        public DigimonContext() : base("name=DigimonConnection") { }

        public DbSet<Domador> Domadores { get; set; }
        public DbSet<Digimon> Digimones { get; set; }
    }
}