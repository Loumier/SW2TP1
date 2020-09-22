using ExemploAula01.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAula01.Repositorio
{
    class LivroRepositorioFake : ILivroRepositorio
    {

        private ListaDeLeitura _paraLer;
        private ListaDeLeitura _lendo;
        private ListaDeLeitura _lidos;



        public ListaDeLeitura ParaLer => _paraLer;
        public ListaDeLeitura Lendo => _lendo;
        public ListaDeLeitura Lidos => _lidos;


        public IEnumerable<Livro> Todos => throw new System.NotImplementedException();


        public void Incluir(Livro livro)
        {
            throw new System.NotImplementedException();
        }

        LivroRepositorioFake()
        {
            var l1 = new Livro { Titulo = "Livro 1", Autor = "Autor 1" };
            var l2 = new Livro { Titulo = "Livro 2", Autor = "Autor 2" };
            var l3 = new Livro { Titulo = "Livro 3", Autor = "Autor 3" };
            var l4 = new Livro { Titulo = "Livro 4", Autor = "Autor 4" };
            var l5 = new Livro { Titulo = "Livro 5", Autor = "Autor 5" };
            var l6 = new Livro { Titulo = "Livro 6", Autor = "Autor 6" };
            var l7 = new Livro { Titulo = "Livro 7", Autor = "Autor 7" };
            var l8 = new Livro { Titulo = "Livro 8", Autor = "Autor 8" };
            var l9 = new Livro { Titulo = "Livro 9", Autor = "Autor 9" };
            
            _paraLer = new ListaDeLeitura("Para Ler", l1, l3, l4);
            _lendo = new ListaDeLeitura("Lendo", l2, l7, l6);
            _lidos = new ListaDeLeitura("Lidos", l5, l8, l9);

        }




    }
}
