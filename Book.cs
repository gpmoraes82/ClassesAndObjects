namespace ClassesAndObjects;

public class Book
{
    private string? _title;
    private string? _author;
    private int _pages;

    public string Title
    {
        get { return _title; }
        set
        {
            _title = (value != null) ? value : "N/A";
        }
    }

    public string Author
    {
        get { return _author; }
        set
        {
            _author = (value != null) ? value : "N/A";
        }
    }

    public int Pages
    {
        get { return _pages; }
        set
        {
            _pages = (value >= 0) ? value : 0;
        }
    }

    public Book()
    {

    }

    //Contructor overload for testing
    public Book(string? title, string? author, int pages)
    {
        Console.WriteLine("Creating book ...");

        Title = title;
        Author = author;
        Pages = pages;

    }

}
