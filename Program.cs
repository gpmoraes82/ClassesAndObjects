namespace ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book();
        book1.title = "3 Body Problem";
        book1.author = "Liu Cixin";
        book1.pages = 302;

        Console.WriteLine(book1.title);

        Console.ReadLine();
    }
}
