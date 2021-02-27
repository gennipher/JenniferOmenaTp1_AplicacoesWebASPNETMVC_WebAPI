using Apresentacao.Models.Lists;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Apresentacao.Controllers
{
    public class ListsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Amigos()
        {
            var viewModel = new AmigosViewModel();

            viewModel.Amigos = new List<Amigo>()
            {
                new Amigo{Id = "1", Nome = "Jennifer", Sobrenome = "Omena", Email = "jennifer@gmail.com"},
                new Amigo{Id = "2", Nome = "Marta", Sobrenome = "Estevez", Email = "marta@gmail.com"},
                new Amigo{Id = "3", Nome = "Wanir", Sobrenome = "Carvalho", Email = "wanir@gmail.com"},
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult ManterAmigos(string[] amigoSelecionado)
        {
            AmigosViewModel.AmigosSelecionados = amigoSelecionado;

            return RedirectToAction("Amigos");
        }

        

        public IActionResult Amigos2()
        {
            var viewModel = new AmigosViewModel();

            viewModel.Amigos = new List<Amigo>()
            {
                new Amigo{Id = "4", Nome = "Leonardo", Sobrenome = "Junger", Aniversario = "16/06/1993"},
                new Amigo{Id = "5", Nome = "Luciano", Sobrenome = "Mascarenhas", Aniversario = "21/02/1996"},
                new Amigo{Id = "6", Nome = "Heitor", Sobrenome = "Ferraz", Aniversario = "01/02/1969"},
            };
            return View(viewModel);
        }

        public IActionResult ManterAmigos2(string[] amigo2Selecionado)
        {
            AmigosViewModel.Amigos2Selecionados = amigo2Selecionado;

            return RedirectToAction("Amigos2");
        }
    }
}
