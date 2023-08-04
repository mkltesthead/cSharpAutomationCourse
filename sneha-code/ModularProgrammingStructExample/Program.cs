// Define a struct for a 2D Point
struct Book
{
    public string Title;
    public string Author;
    public double Price;

    // Constructor to initialize the point
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }

    // Method to display the point's coordinates
    public void DisplayBookDetails()
    {
        Console.WriteLine($"Book Details:\nTitle:{Title}\nAuthor:{Author}\nPrice:{Price}$");
    }
}

class Program
{
    static void Main()
    {
        // Create two Point instances using the struct
        Book book1 = new Book("Tuesdays With Morrie", "Mitch Albom", 134.5);
        Book book2 = new Book("Yayati", "Vishnu Khandekar", 125.9);

        // Display the points
        book1.DisplayBookDetails();
        book2.DisplayBookDetails();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

