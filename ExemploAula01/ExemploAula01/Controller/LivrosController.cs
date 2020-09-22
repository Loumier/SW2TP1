using ExemploAula01.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.;

namespace ExemploAula01.Controller
{
    class LivrosController : Controller
    {
        public IEnumerable<Livro> Livros { get; set; }

        private static string CarregaLista(IEnumerable<Livros> livros)
        {
            var conteudoArquivo = HtmlUtils.CarregaArquivoHTML("lista");

            return conteudoArquivo.Replace("#NOVO-ITEM", "");
        }

        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.PararLer.Livros;
            return View("lista");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("lista");
        }
    }
}
