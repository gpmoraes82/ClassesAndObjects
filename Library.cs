namespace ClassesAndObjects;

public class Library
{
    private string? _name;

    public Library(string? name)
    {
        if (name != null) { Name = name; }
        else { Name = "THe City Library"; }
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

    //TODO: modify to use list
    public string bookSuggestion (Book bookA, Book bookB){

        if(bookA.Pages > bookB.Pages){
            return bookB.Title;
        } else {
            return bookA.Title;
        }

    }
}
