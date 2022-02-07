namespace AMHP.Avaliacao.Domain
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataHora { get; private set; }

        public ICollection<UsuarioPerguntaResposta> UsuarioPerguntaRespostas { get; set; }

        protected Usuario()
        {

        }
        public Usuario(string nome)
        {
            Id = Guid.NewGuid();

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("Nome não informado");
            }

            Nome = nome;

            DataHora = DateTime.Now

            UsuarioPerguntaRespostas = new List<UsuarioPerguntaResposta>();
        }

        public void DefirnirResposta(UsuarioPerguntaResposta resposta)
        {
            UsuarioPerguntaRespostas.Add(resposta);
        }
    }
}
