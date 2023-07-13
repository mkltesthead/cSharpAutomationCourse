using System;

public interface IProduct
{
    double Price { get; set; }
    string Name { get; set; }
    string Color { get; set; }
}

public class Book : IProduct
{
    public double Price { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Author { get; set; }
    public int NumberOfPages { get; set; }
    public string ISBN { get; set; }
}

public class Customer
{
    public static void Main()
    {
        IProduct book = new Book();
        book.Name = "String Theory - A Modern Take";
        book.Color = "Green";
        book.Price = 74.99;

        Console.WriteLine("Book Details:");
        Console.WriteLine($"Name: {book.Name}");
        Console.WriteLine($"Color: {book.Color}");
        Console.WriteLine($"Price: {book.Price:C}");

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}


public class Book : IProduct, IKindleItem
{
    // Class implementation
}
