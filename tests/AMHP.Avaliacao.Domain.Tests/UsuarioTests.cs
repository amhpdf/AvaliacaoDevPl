using System;
using Xunit;

namespace AMHP.Avaliacao.Domain.Tests
{
    public class UsuarioTests
    {
        [Fact]
        public void UsuarioTests_CriarUsurio_ComNome()
        {
            //Arrange
            //Act
            var usuario = new Usuario("Teste");

            //Assert
            Assert.NotNull(usuario);
            Assert.Equal("Teste 1", usuario.Nome);
        }

        [Fact]
        public void UsuarioTests_CriarUsurio_SemNome()
        {
            //Arrange
            //Act
            var act =()=> new Usuario(null);

            //Assert
            var exp = Assert.Throws<Exception>(act);
            Assert.Equal("Nome do candidato não informado", exp.Message);
        }
    }
}