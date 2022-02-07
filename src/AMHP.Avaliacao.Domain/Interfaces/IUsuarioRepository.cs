namespace AMHP.Avaliacao.Domain.Interfaces
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuario ObterPorId(Guid id);
        Usuario Adicionar(Usuario usuario);
    }
}
