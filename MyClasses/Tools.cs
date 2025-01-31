namespace ClassesAndObjects;

public static class Tools
{
    private static int booksCount = 0;

    public static void BooksCounter(){
        booksCount++;
    }

    public static int BooksQuantity(){
        return booksCount;
    }
}
