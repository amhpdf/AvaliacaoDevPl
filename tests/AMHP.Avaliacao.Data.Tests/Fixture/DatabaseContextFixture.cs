using AMHP.Avaliacao.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;

namespace AMHP.Avaliacao.Data.Tests.Fixture
{
    public class DatabaseContextFixture : IDisposable
    {
        private readonly AvaliacaoContext _avaliacaoContext;

        public void Dispose()
        {
            _avaliacaoContext?.Dispose();
            GC.SuppressFinalize(this);
        }

        public AvaliacaoContext ObterAvaliacaoContext()
        {
            return _avaliacaoContext;
        }

        public DatabaseContextFixture()
        {
            var builder = new DbContextOptionsBuilder<AvaliacaoContext>();

            builder.UseInMemoryDatabase(databaseName: "AvaliacaoContextDbInMemory");

            var dbContextOptions = builder.Options;

            //_avaliacaoContext = new AvaliacaoContext(dbContextOptions);

            //_avaliacaoContext.Database.EnsureDeleted();

            //_avaliacaoContext.Database.EnsureCreated();
        }
    }
}
