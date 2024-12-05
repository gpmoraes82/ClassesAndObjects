namespace ClassesAndObjects;

public class Library
{
    public string name;

    public Library(string name){
        this.name = name;
    }

    public string bookSuggestion (Book bookA, Book bookB){

        if(bookA.pages > bookB.pages){
            return bookB.title;
        } else {
            return bookA.title;
        }

    }
}
