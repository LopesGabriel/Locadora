using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Locadora.Models
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext (DbContextOptions<LocadoraContext> options)
            : base(options)
        {
        }

        public DbSet<Locadora.Models.Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
        public DbSet<Produtora> Produtora { get; set; }
    }
}
