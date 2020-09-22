using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWTP01
{
    public class Test
    {
        public Test(){
            Console.WriteLine("Testing...");
            this.readBookCsv();
            this.createAuthor();
            this.viewAuthors();
            this.createBook();
            this.viewBooks();
        }

        public void readBookCsv(){
            try{
                bookController bookC = new bookController();
                var Books = bookC.searchBook();
                Console.WriteLine("Success");
            }
            catch (IOException e){
                Console.WriteLine("Failed");
                throw;
            }            
        }

        public void createAuthor(){
            try{
                Author author = new Author();
                author.Name = "Guilherme Borges Cunha";
                author.Email = "loumier28@gmail.com";
                author.Gender = 'm';
                Console.WriteLine("Successfully created");
            }
            catch (IOException e){
                Console.WriteLine("Failed");
                throw;
            }
        }

        public void createBook(){           
            try{
                Author author = new Author();
                author.Name = "Dante Alighieri";
                author.Email = "alighierizinhozika@hotmail.com";
                author.Gender = 'M';

                Author[] autores = { author };

                Book book1 = new Book("Livro de fantasia", autores, 100.00);

                Book book2 = new Book("Livro de autoajuda", autores, 100.00, 5);
            }
            catch (IOException e)
            {
                Console.WriteLine("Failed");
                throw;
            }
        }

        public void viewBooks()
        {
            try
            {
                Console.WriteLine("Success");

                bookController bookC = new bookController();
                var Books = bookC.searchBook();

                Console.WriteLine("Success");

                foreach (var book in Books)
                {                   
                    Console.WriteLine($"   book ToString ");
                    Console.WriteLine(book.ToString());
                    Console.WriteLine($"   getAuthorNames | {book.getAuthorNames()}");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Failed");
                throw;
            }
        }

        public void viewAuthors()
        {
            try
            {
                Author author = new Author();
                author.Name = "Dan Brown";
                author.Email = "mrbrown@gmail.com";
                author.Gender = 'M';

                Author[] authors = { author };

                Console.WriteLine($"Author: ({author.Name}, { author.Email}, {author.Gender})");              
            }
            catch (IOException e)
            {
                Console.WriteLine("Failed");
                throw;
            }
        }
    }
}
