namespace ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.title = "3 Body Problem";
        book1.author = "Liu Cixin";
        book1.pages = 302;

        Book book2 = new Book();
        book2.title = "The Warriors";
        book2.author = "Sol Yurick";
        book2.pages = 181;

        Console.WriteLine(book1.title);

        Console.WriteLine(book2.title);

        Console.ReadLine();
    }
}
