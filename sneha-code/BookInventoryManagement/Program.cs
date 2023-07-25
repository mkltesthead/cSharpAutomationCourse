namespace BookInventoryManagement
{
    class Book
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int YearOfPublication { get; set; }
        public string? ISBN { get; set; }
    }

    class BookInventory
    {
        private Book[] books;

        public BookInventory(int size)
        {
            books = new Book[size];
        }

        public void AddBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] = book;
                    Console.WriteLine("Book added successfully!");
                    return;
                }
            }

            Console.WriteLine("Not able to add more books.Book inventory is full.");
        }

        public void SearchByTitle(string? title)
        {
            Console.WriteLine("Searching for books by title: " + title);
            bool found = false;

            foreach (Book book in books)
            {
                if (book != null && book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayBookDetails(book);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No books found with the given title.");
            }
        }

        public void DisplayAllBooks()
        {
            Console.WriteLine("Listing all books in the inventory:");
            foreach (Book book in books)
            {
                if (book != null)
                {
                    DisplayBookDetails(book);
                }
            }
        }

        private void DisplayBookDetails(Book book)
        {
            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.WriteLine("Year of Publication: " + book.YearOfPublication);
            Console.WriteLine("ISBN: " + book.ISBN);
            Console.WriteLine();
        }
    }

    class BookInventoryManagementSystem
    {
        static void Main(string[] args)
        {
            BookInventory inventory = new BookInventory(5);

            Console.WriteLine("Enter details for new books (up to 5 books):");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Book " + (i + 1) + ":");

                Console.Write("Title: ");
                string? title = Console.ReadLine();

                Console.Write("Author: ");
                string? author = Console.ReadLine();

                Console.Write("Year of Publication: ");
                int yearOfPublication = int.Parse(Console.ReadLine());

                Console.Write("ISBN: ");
                string? isbn = Console.ReadLine();

                Book newBook = new Book
                {
                    Title = title,
                    Author = author,
                    YearOfPublication = yearOfPublication,
                    ISBN = isbn
                };
                inventory.AddBook(newBook);

                Console.WriteLine();
                Console.Write("Add another book? (Y/N): ");
                string response = Console.ReadLine();
                if (response.ToUpper() != "Y")
                {
                    break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Search for books by title");
            Console.WriteLine("2. Display all books");

            while (true)
            {
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter a title to search: ");
                        string searchTitle = Console.ReadLine();
                        inventory.SearchByTitle(searchTitle);
                        break;
                    case "2":
                        inventory.DisplayAllBooks();
                        break;
                    default:
                        Console.WriteLine("Invalid option selected.");
                        break;
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}