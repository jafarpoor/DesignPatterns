using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDp
{
    public class Book : LibraryItem
    {
        public string author { get; set; }
        public string title { get; set; }

     
        public  Book(string author, string title, int numCopies)
        {
            this.author = author;
            this.title = title;
            this.NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("Book ------ ");
            Console.WriteLine(" Author: {0}", author);
            Console.WriteLine(" Title: {0}", title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}
