using System.ComponentModel.DataAnnotations;

namespace AMHP.Avaliacao.Site.Models
{
    public class UsuarioAvaliacaoViewModel
    {
        [Required(ErrorMessage = "Informe o nome!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Pergunta não respondida!")]
        public int? Pergunta_1 { get; set; }
        [Required(ErrorMessage = "Pergunta não respondida!")]
        public int? Pergunta_2 { get; set; }
        [Required(ErrorMessage = "Pergunta não respondida!")]
        public int? Pergunta_3 { get; set; }
        [Required(ErrorMessage = "Pergunta não respondida!")]
        public int? Pergunta_4 { get; set; }
        [Required(ErrorMessage = "Pergunta não respondida!")]
        public int? Pergunta_5 { get; set; }
        [Required(ErrorMessage = "Pergunta não respondida!")]
        public int? Pergunta_6 { get; set; }
        [Required(ErrorMessage = "Pergunta não respondida!")]
        public int? Pergunta_7 { get; set; }
        [Required(ErrorMessage = "Pergunta não respondida!")]
        public int? Pergunta_8 { get; set; }
        [Required(ErrorMessage = "Pergunta não respondida!")]
        public int? Pergunta_9 { get; set; }
        [Required(ErrorMessage = "Pergunta não respondida!")]
        public int? Pergunta_10 { get; set; }
    }
}
