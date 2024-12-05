namespace ClassesAndObjects;

public class Book
{
    public Book(string? title, string? author, int pages)
    {
        Console.WriteLine("Creating book ...");
    }

    public string? title;
    public string? author;
    public int pages;
}
