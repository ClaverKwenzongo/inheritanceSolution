// See https://aka.ms/new-console-template for more information
using System;

namespace inheritanceSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Software software = new Software();

            Console.WriteLine($"The book {software.ProductName} authored by {book.authorName} is priced at R{book.ProductPrice}.");
            Console.WriteLine($"The product code is {software.ProductCode}");
            Console.WriteLine($"The book is about {software.ProductDescription}, the version number is {software.version}");
        }
    }
}

