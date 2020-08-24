using System;
using System.Collections.Generic;
using System.Text;
using bitzen.Models;
using Microsoft.AspNetCore.Identity;
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

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Abastecimento> Abastecimentos { get; set; }
         

    }
}
