namespace ClassesAndObjects;

public class Book
{
    public string? title;
    public string? author;
    public int pages;

    public Book () {
        
    }

    public Book(string? title, string? author, int pages)
    {
        Console.WriteLine("Creating book ...");

        this.title = title;
        this.author = author;
        this.pages = pages;
    }

}
