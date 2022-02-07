using AMHP.Avaliacao.Data.Context;
using AMHP.Avaliacao.Domain;
using AMHP.Avaliacao.Domain.Interfaces;

namespace AMHP.Avaliacao.Data
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private AvaliacaoContext _avaliacaoContext;

        public UsuarioRepository(AvaliacaoContext avaliacaoContext)
        {
            _avaliacaoContext = avaliacaoContext;
        }

        public Usuario AdicionarUsuario(Usuario usuario)
        {
            _avaliacaoContext.Usuarios.Add(usuario);

            _avaliacaoContext.SaveChanges();

            return usuario;
        }

        public void Dispose()
        {
            _avaliacaoContext?.Dispose();
            GC.SuppressFinalize(this);
        }

        public Usuario ObterPorId(Guid id) => _avaliacaoContext.Usuarios.Find(id);
    }
}
