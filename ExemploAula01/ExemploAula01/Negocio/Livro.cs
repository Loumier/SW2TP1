using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploAula01.Negocio
{
    class Livro
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public ListaDeLeitura Lista { get; set; }

        public string Detalhes()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Detalhes do Livro");
            stringBuilder.AppendLine("======");
            stringBuilder.AppendLine($"Titulo : {Titulo}");
            stringBuilder.AppendLine($"Autor : {Autor}");
            stringBuilder.AppendLine($"Lista : {Lista.Titulo}");
            return stringBuilder.ToString();

        }


        public override string ToString()
        {
            return $"{Titulo} - {Autor}";
        }

    }
}
