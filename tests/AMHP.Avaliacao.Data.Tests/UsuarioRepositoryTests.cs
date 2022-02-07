using AMHP.Avaliacao.Data.Tests.Fixture;
using AMHP.Avaliacao.Domain;
using AMHP.Avaliacao.Domain.Interfaces;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AMHP.Avaliacao.Data.Tests
{
    public class UsuarioRepositoryTests : IClassFixture<DatabaseContextFixture>
    {
        private readonly DatabaseContextFixture _fixture;
        
        private readonly IUsuarioRepository _repository;

        public UsuarioRepositoryTests(DatabaseContextFixture fixture)
        {
            _fixture = fixture;

            _repository = new UsuarioRepository(_fixture.ObterAvaliacaoContext());
        }

        [Fact]
        public void UsuarioRepository_Adicionar_RetornarAdicionado()
        {
            //Arrange
            var domain = new Faker<Usuario>()
                            .CustomInstantiator(f => new Usuario(f.Person.FullName))
                            .Generate();

            //act
            var usuario = _repository.Adicionar(domain);

            //assert
            Assert.NotNull(usuario);
            Assert.Equal(domain.Id, usuario.Id);
        }

        [Fact]
        public void UsuarioRepository_ObterPorId_Null()
        {
            //Arrange
            var guid = Guid.NewGuid();

            //act
            var usuario = _repository.ObterPorId(guid);

            //assert
            Assert.Null(usuario);
        }

        [Fact]
        public void UsuarioRepository_ObterPorId_NotNull()
        {
            //Arrange
            var domain = new Faker<Usuario>()
                            .CustomInstantiator(f => new Usuario(f.Person.FullName))
                            .Generate();

            _repository.Adicionar(domain);

            //act
            var usuario = _repository.ObterPorId(domain.Id);

            //assert
            Assert.Null(usuario);
            Assert.Equal(domain.Id, usuario.Id);
        }
    }
}
