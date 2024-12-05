namespace ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {

        Book book1 = new Book("3 Body Problem", "Liu Cixin", 302);
        Console.WriteLine(book1.title);

        Book book2 = new Book("The Warriors", "Sol Yurick", 181);
        Console.WriteLine(book2.title);

        Console.ReadLine();
    }
}
