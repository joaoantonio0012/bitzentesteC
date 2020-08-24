using bitzen.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bitzen.Data
{
    public class ApplicationDbContext : IdentityDbContext<CamposUsuario>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Seed();
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Abastecimento> Abastecimentos { get; set; }


    }
}