using AMHP.Avaliacao.Domain;
using Microsoft.EntityFrameworkCore;

namespace AMHP.Avaliacao.Data.Context
{
    public class AvaliacaoContext :DbContext
    {
        public AvaliacaoContext(DbContextOptions<AvaliacaoContext> options) : base(options) 
        { 
            
        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
