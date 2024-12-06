namespace ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library("Alexandria");

        Book[] books = new Book[2];

        books[0] = new Book("3 Body Problem", "Liu Cixin", 302);
        books[1] = new Book("The Warriors", "Sol Yurick", 181);
        

        //TODO: add text formating

        for (int i = 0 ; i <= books.Length - 1 ; i++) {
            
            Console.WriteLine("Creating book ...");

            Console.WriteLine(books[i].Title);
            Console.WriteLine(books[i].Author);
            Console.WriteLine(books[i].Pages);

        }

        // Console.WriteLine($"\nBook for read if have time: {library.bookSuggestion(book1, book2)}");

        Console.ReadLine();
    }
}
