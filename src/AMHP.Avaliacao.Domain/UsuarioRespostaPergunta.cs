namespace AMHP.Avaliacao.Domain
{
    public class UsuarioPerguntaResposta
    {
        public Guid Id { get; private set; }

        public Guid UsuarioId { get; private set; }

        public int Pergunta { get; private set; }

        public int Resposta { get; private set; }

        protected UsuarioPerguntaResposta()
        {

        }

        public UsuarioPerguntaResposta(int pergunta, int resposta, Guid userId)
        {
            Id = Guid.NewGuid();

            Pergunta = pergunta;

            Resposta = resposta;

            UsuarioId = userId;
        }
    }
}
