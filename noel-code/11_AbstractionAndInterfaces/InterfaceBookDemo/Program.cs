using System;

public interface IProduct
{
    double Price { get; set; }
    string Name { get; set; }
    string Color { get; set; }
    string Author { get; set; }
    int NumberOfPages { get; set; }
    string ISBN { get; set; }
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
        book.Author = "Robert Graves";
        book.NumberOfPages = 374;
        book.Color = "Green";
        book.Price = 74.99;
        book.ISBN = "978312716541";

        Console.WriteLine("Book Details:");
        Console.WriteLine($"Name: {book.Name}");
        Console.WriteLine($"Author: {book.Author}");
        Console.WriteLine($"Number of Pages: {book.NumberOfPages}");
        Console.WriteLine($"ISBN: {book.ISBN}");
        Console.WriteLine($"Color: {book.Color}");
        Console.WriteLine($"Price: {book.Price:C}");

        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}