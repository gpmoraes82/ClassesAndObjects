namespace ClassesAndObjects;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library("Alexandria");

        Console.WriteLine($"Welcome to {library.Name} Library");

        Librarian employeeLibrarian = new Librarian("Max", 42, "8dh47sall");

        Console.WriteLine($"\n Hiring: {employeeLibrarian.Name}, {employeeLibrarian.Age}");
        Console.WriteLine(" ID:" + employeeLibrarian.EmployeeId.PadLeft(employeeLibrarian.EmployeeId.Length + 1, ' '));

        Book[] books = new Book[2];
        books[0] = new Book("3 Body Problem", "Liu Cixin", 302);
        books[1] = new Book("The Warriors", "Sol Yurick", 181);

        for (int i = 0; i < Tools.BooksQuantity(); i++)
        {
            string pagesStrParser = "-1";
            int pagesLength = 0;

            Console.WriteLine(books[i].Title.PadLeft(books[i].Title.Length + 1, '-'));

            Console.WriteLine(books[i].Author.PadLeft(books[i].Author.Length + 3));

            pagesStrParser = books[i].Pages.ToString();
            pagesLength = pagesStrParser.Length;
            Console.WriteLine(pagesStrParser.PadLeft(pagesLength + 3));

        }

        Console.WriteLine($"\nBook for read if have time: {library.bookSuggestion(books)}");

        Console.WriteLine($"\nN° of Books add to {library.Name}: {Tools.BooksQuantity()}");

        Console.ReadLine();
    }
}
