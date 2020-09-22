using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWTP01
{
    class Book
    {
        public string name { get; set; }
        public string email { get; set; }
        public double price { get; set; }
        public Author[] Authors { get; set; }
        public int quantity { get; set; }

        public Book(string name, Author[] authors, double price){
            this.name = name;
            Authors = authors;
            this.price = price;
        }

        public Book(string name, Author[] authors, double price, int quantity)
        {
            this.name = name;
            Authors = authors;
            this.price = price;
            this.quantity = quantity;
        }

        public override string ToString(){

            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Name = {name}");
            stringBuilder.AppendLine($"Author");

            foreach (var author in Authors){
                if (author != null){
                stringBuilder.AppendLine($"      Author {author.Name}, Email {author.Email} , Gender {author.Gender.ToString()}");
                }
            }
            
            stringBuilder.AppendLine($"Email = {email}");
            stringBuilder.AppendLine($"Price = {price}");
            stringBuilder.AppendLine($"Quantity = {quantity}");

            return stringBuilder.ToString();
        }

        public string getAuthorNames(){
            string result = "";

            foreach (var author in Authors.Select((value, i) => new { i, value }))
            {
                if (author.value != null)
                {
                    if (author.i == (Authors.Length - 1))
                    {
                        result += ", " + author.value.Name;
                    }
                    else
                    {
                        result += author.value.Name ;
                    }
                }
            }
            return result;
        }
    }
}
