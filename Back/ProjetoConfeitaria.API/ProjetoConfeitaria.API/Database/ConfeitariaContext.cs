using Confeitaria.Models;
using Microsoft.EntityFrameworkCore;

namespace Confeitaria.API.Database
{
    public class ConfeitariaContext : DbContext
    {
        public ConfeitariaContext(DbContextOptions<ConfeitariaContext> options): base(options)
        {
        
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Bolo> Bolo { get; set; }
        public DbSet<Estabelecimento> Estabelecimento { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
    }
}
