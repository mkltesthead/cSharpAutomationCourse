using System;

public interface IProduct
{
    void DisplayInfo();
}

public interface IKindleItem
{
    void Read();
}

public class Book : IProduct, IKindleItem
{
    public void DisplayInfo()
    {
        Console.WriteLine("Book information displayed.");
    }

    public void Read()
    {
        Console.WriteLine("Reading book...");
    }
}

public class Program
{
    public static void Main()
    {
        Book book = new Book();
        book.DisplayInfo();
        book.Read();

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();

    }
}