using ConsoleApp1.Models.ConcreteClasses;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Library library = new Library("The National Library");
            Book book1 = new Book("The Adventures in c#", 5);
            Book book2 = new Book("The awesome story of me", 15);
            Book book3 = new Book("The spontanious story of spelling correctly", 25);
            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Lend(book2);
        }
    }
}
