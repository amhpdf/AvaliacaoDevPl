using AMHP.Avaliacao.Data;
using AMHP.Avaliacao.Data.Context;
using AMHP.Avaliacao.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AMHP.Avaliacao.Site.Configuration
{
    public static class Extensions
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AvaliacaoContext>(option => option.UseSqlite(configuration.GetConnectionString("Avaliacao")));

            //Registra injeção de dependência aqui!
        }
    }
}
