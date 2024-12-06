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
            if (value != null) { _title = value; }
            else { _title = "N/A"; }
        }
    }

    public string Author
    {
        get { return _author; }
        set
        {
            if (value != null) { _author = value; }
            else { _author = "N/A"; }
        }
    }

    public int Pages
    {
        get { return _pages; }
        set
        {
            if (value >= 0) { _pages = value; }
            else { _pages = 0; }
        }
    }

    public Book()
    {

    }

    //Contructor overload for testing
    public Book(string? title, string? author, int pages)
    {
        Console.WriteLine("Creating book ...");
        if (title != null || author != null || pages >= 0)
        {

            Title = title;
            Author = author;
            Pages = pages;

        }
        else
        {
            Title = "N/A";
            Author = "N/A";
            Pages = 0;
        }

    }

}
