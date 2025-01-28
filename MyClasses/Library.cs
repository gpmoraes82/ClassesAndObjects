namespace ClassesAndObjects;

public class Library
{
    private string? _name;

    public Library(string? name)
    {
        if (name != null) { Name = name; }
        else { Name = "The City Library"; }
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (value != null) { _name = value; }
            else { _name = "The City Library"; }
        }
    }

    public string bookSuggestion(Book[] books)
    {
        string lessPages = "N/A";

        foreach (Book b1 in books)
        {
            lessPages = b1.Title;

            foreach (Book b2 in books)
            {

                lessPages = (b2.Pages < b1.Pages) ? b2.Title : b1.Title;

            }
        }

        return lessPages;
    }
}
