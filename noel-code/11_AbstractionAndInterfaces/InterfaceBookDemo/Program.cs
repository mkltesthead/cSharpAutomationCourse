using System;
using System.Collections;
using System.Collections.Generic;

public interface IProduct
{
    double Price { get; set; }
    string Name { get; set; }
    string Color { get; set; }
}

public interface IPurchaseable
{
    void displayDetails();
    double getTotalPrice(IDictionary<string, object> purchaseOptions);
}

public class Book : IProduct, IPurchaseable
{
    public double Price { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }
    public string Author { get; set; }
    public int NumberOfPages { get; set; }
    public string ISBN { get; set; }

    public void displayDetails()
    {
        Console.WriteLine(string.Join("\r\n", new string[] {
            "Book Details:",
            $"Name: {this.Name}",
            $"Color: {this.Color}",
            $"Price: {this.Price:C}",
            $"Author: {this.Author}",
            $"Pages: {this.NumberOfPages}",
            $"ISBN: {this.ISBN}"
        }));
    }
    public double getTotalPrice(IDictionary<string, object> purchaseOptions)
    {
        if (purchaseOptions.ContainsKey("number of books") && purchaseOptions["number of books"] is int)
        {
            return (int)purchaseOptions["number of books"] * this.Price;
        }
        else
        {
            throw new ArgumentException("Parameter must be number of books");
        }
    }
}

public class Coffee : IProduct, IPurchaseable
{
    public double Price { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public void displayDetails()
    {
        Console.WriteLine(string.Join("\r\n", new string[] {
            "Coffee Details:",
            $"Name: {this.Name}",
            $"Color: {this.Color}",
            $"Price:",
            $"    short: {this.Price * 1:C}",
            $"    tall: {this.Price * 2:C}",
            $"    grande: {this.Price * 3:C}",
            $"    venti: {this.Price * 4:C}"
        }));
    }
    public double getTotalPrice(IDictionary<string, object> purchaseOptions)
    {
        Dictionary<string, int> coffeeSizes = new Dictionary<string, int>()
        {
            { "short", 1 },
            { "tall", 2 },
            { "grande", 3 },
            { "venti", 4 }
        };
        if (purchaseOptions.ContainsKey("number of coffees") && purchaseOptions["number of coffees"] is int
            && purchaseOptions.ContainsKey("size of coffee") && purchaseOptions["size of coffee"] is string && coffeeSizes.ContainsKey((string)purchaseOptions["size of coffee"]))
        {
            return (int)purchaseOptions["number of coffees"] * this.Price * coffeeSizes[(string)purchaseOptions["size of coffee"]];
        }
        else
        {
            throw new ArgumentException("Parameters must be number of coffees and their sizes");
        }
    }
}

public class Customer
{
    public static void Main()
    {
        Customer app = new Customer();
        object[] goods = new object[]
        {
            new Book()
            {
                Name = "Spare",
                Color = "Green",
                Price = 20.99,
                Author = "Prince Harry",
                NumberOfPages = 500,
                ISBN = "HRH005"
            },
            new Book()
            {
                Name = "A Suitable Boy",
                Color = "Black",
                Price = 15.99,
                Author = "Vikram Seth",
                NumberOfPages = 1500,
                ISBN = "ASB003"
            },
            new Coffee()
            {
                Name = "Latte",
                Color = "Black",
                Price = 1.99
            },
            new Coffee()
            {
                Name = "Mocha",
                Color = "Brown",
                Price = 2.99
            },
            new Coffee()
            {
                Name = "Macchiato",
                Color = "Cream",
                Price = 3.99
            },
            new Coffee()
            {
                Name = "Cappuccino",
                Color = "Off white",
                Price = 4.99
            },
            new Coffee()
            {
                Name = "Americano",
                Color = "White",
                Price = 5.99
            },
            new Coffee()
            {
                Name = "Espresso",
                Color = "Black",
                Price = 6.99
            },
            new Coffee()
            {
                Name = "Flat White",
                Color = "White",
                Price = 7.99
            }
        };

        double total = 0;
        string choice;
        while (true)
        {
            int count = 0;
            Console.WriteLine("The available items are:");
            foreach (var item in goods)
            {
                count++;
                if (item is Book)
                {
                    Book book = (Book)item;
                    Console.WriteLine($"    {count}) {book.Name} {book.Price:C}");
                }
                else
                {
                    Coffee coffee = (Coffee)item;
                    Console.WriteLine($"    {count}) {coffee.Name} {coffee.Price:C}");
                }
            };
            choice = app.getInput("Which item are you interested in (Press return to finish)?").ToLower();
            if (choice == "")
            {
                break;
            }

            foreach (var item in goods)
            {
                if (item is Book && ((Book)item).Name.ToLower() == choice)
                {
                    Console.WriteLine();
                    ((Book)item).displayDetails();
                    int number = Convert.ToInt32(app.getInput($"How many copies of {((Book)item).Name} would you like to purchase?"));
                    total += ((Book)item).getTotalPrice(new Dictionary<string, object>() {
                        { "number of books", number }
                    });
                    break;
                }
                else if (item is Coffee && ((Coffee)item).Name.ToLower() == choice)
                {
                    Console.WriteLine();
                    ((Coffee)item).displayDetails();
                    int number = Convert.ToInt32(app.getInput($"How many {((Coffee)item).Name}s would you like to purchase?"));
                    string size = app.getInput($"What size of {((Coffee)item).Name} would you like to purchase - short, tall, grande or venti?").ToLower();
                    total += ((Coffee)item).getTotalPrice(new Dictionary<string, object>() {
                        { "number of coffees", number },
                        { "size of coffee", size }
                    });
                    break;
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Your total bill is {total:C}");
        Console.WriteLine();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    public string getInput(string prompt)
    {
        Console.WriteLine(prompt);
        string option = Console.ReadLine();
        return option;
    }
}