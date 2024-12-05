﻿namespace ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {

        Library library = new Library("Alexandria");

        Book book1 = new Book("3 Body Problem", "Liu Cixin", 302);
        Console.WriteLine(book1.title);

        Book book2 = new Book("The Warriors", "Sol Yurick", 181);
        Console.WriteLine(book2.title);

        Console.WriteLine($"Book for read if have time: {library.bookSuggestion(book1, book2)}");

        Console.ReadLine();
    }
}
