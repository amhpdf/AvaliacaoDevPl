using AMHP.Avaliacao.Domain;
using AMHP.Avaliacao.Domain.Interfaces;
using AMHP.Avaliacao.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AMHP.Avaliacao.Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public HomeController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public IActionResult Index()
        {
            return View(new UsuarioAvaliacaoViewModel());
        }

        [HttpPost]
        public IActionResult Index(UsuarioAvaliacaoViewModel usuario)
        {
            if (!ModelState.IsValid)
            {
                return View(usuario);
            }

            var id = GravarAvaliacaoUsuario(usuario);

            return RedirectToAction("Finalizado", new { id });
        }

        private Guid GravarAvaliacaoUsuario(UsuarioAvaliacaoViewModel usuario)
        {
            var usr = new Usuario(usuario.Nome);

            usr.DefirnirResposta(new UsuarioPerguntaResposta(1, usuario.Pergunta_1.Value, usr.Id));

            usr.DefirnirResposta(new UsuarioPerguntaResposta(2, usuario.Pergunta_2.Value, usr.Id));

            usr.DefirnirResposta(new UsuarioPerguntaResposta(3, usuario.Pergunta_3.Value, usr.Id));

            usr.DefirnirResposta(new UsuarioPerguntaResposta(4, usuario.Pergunta_4.Value, usr.Id));

            usr.DefirnirResposta(new UsuarioPerguntaResposta(5, usuario.Pergunta_5.Value, usr.Id));

            usr.DefirnirResposta(new UsuarioPerguntaResposta(6, usuario.Pergunta_6.Value, usr.Id));

            usr.DefirnirResposta(new UsuarioPerguntaResposta(7, usuario.Pergunta_7.Value, usr.Id));

            usr.DefirnirResposta(new UsuarioPerguntaResposta(8, usuario.Pergunta_8.Value, usr.Id));

            usr.DefirnirResposta(new UsuarioPerguntaResposta(9, usuario.Pergunta_9.Value, usr.Id));

            usr.DefirnirResposta(new UsuarioPerguntaResposta(10, usuario.Pergunta_10.Value, usr.Id));

            _usuarioRepository.Adicionar(usr);

            return usr.Id;
        }

        public IActionResult Finalizado(Guid id)
        {
            var usr = _usuarioRepository.ObterPorId(id);
            return View(usr);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}