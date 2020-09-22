using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWTP01
{
    class bookController
    {
        private static readonly string CSV = "D:\\netCore\\SW2\\livros.csv";

        public bookController(){}

        public List<Book> searchBook()
        {
            using (var file = File.OpenText(bookController.CSV))
            {
                var books = new List<Book>();
                Author[] autores = new Author[2];

                while (!file.EndOfStream)
                {
                    var textbook = file.ReadLine();

                    if (string.IsNullOrEmpty(textbook))
                    {
                        continue;
                    }
                    var library = textbook.Split(';');

                    var autor1 = new Author();
                    autor1.Name = library[2];

                    autores.SetValue(autor1, 0);

                    if (library.Length == 5)
                    {
                        var autor2 = new Author();
                        autor1.Name = library[5];
                    }
                    var livro = new Book(library[0], autores, double.Parse(library[0]), int.Parse(library[0]));

                    livro.email = library[0];

                    books.Add(livro);
                }
                return books;
            }
        }
    }
}