using System;
using System.Collections.Generic;

namespace Book_Inventory_Management
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public DateTime YearOfPublication { get; set; }

        public long ISBN { get; set; }
    }


internal class Program
{
    static int arr_size = 100;
    static int bookCount = 0;
    public static Book[] books = new Book[arr_size];
    static void Main(string[] args)
    {
        DisplayMenu();
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("\nMenu\n");
        Console.WriteLine("1)Add Book\n");
        Console.WriteLine("2)Book Details\n");
        Console.WriteLine("3)Search Book\n");
        Console.WriteLine("4)Exit\n");

        Console.WriteLine("Select option from above menu : ");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                AddBook();
                break;
            case 2:
                DisplayBooks();
                break;

            case 3:
                SearchBook();
                break;

            case 4:
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Invalid choice. Please select valid option");
                DisplayMenu();
                break;

        }
    }

    public static void AddBook()
    {
        Book book = new Book();


        books[bookCount] = book;

        Console.WriteLine("Enter Book Title:");
        books[bookCount].Title = Console.ReadLine().ToLower();

        Console.WriteLine("Enter Book Author:");
        books[bookCount].Author = Console.ReadLine().ToLower();

        Console.WriteLine("Enter Book Publication Year in MM/DD/YYYY format:");
        books[bookCount].YearOfPublication = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter Book ISBN:");
        books[bookCount].ISBN = Convert.ToInt32(Console.ReadLine());

        bookCount++;

        Console.WriteLine("Do you want to add more books? Yes or No");
        string answer = Console.ReadLine();

        if (answer.ToLower() == "yes")
            AddBook();

        else
            DisplayMenu();


    }

    public static void DisplayBooks()
    {
        bool flag = false;
        for (int j = 0; j < bookCount; j++)
        {
            Console.WriteLine($"Title:{books[j].Title},Author:{ books[j].Author},YearofPublication:{books[j].YearOfPublication},ISBN:{ books[j].ISBN}");
            flag = true;
        }

        if (!flag)
            Console.WriteLine("Book Inventory is Empty");

        DisplayMenu();

    }

    public static void SearchBook()
    {
        bool flag = false;
        Console.WriteLine("Enter Title to search a book:");
        string Title = Console.ReadLine();

        for (int j = 0; j < bookCount; j++)
        {
            if (Title.ToLower() == books[j].Title.ToLower())
            {
                Console.WriteLine("\nBook Found");
                Console.WriteLine($"Title:{books[j].Title},Author:{books[j].Author},YearofPublication:{books[j].YearOfPublication},ISBN:{books[j].ISBN}");
                flag = true;
                break;
            }


        }

        if (!flag)
            Console.WriteLine("Book not found");

        DisplayMenu();

    }
}
}