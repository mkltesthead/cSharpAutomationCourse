using System;
using System.Collections.Generic;

// Step 1: Create a Product Abstract Class
public abstract class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public abstract double CalculateTotalPrice(int quantity);

    public virtual string DisplayProductDetails()
    {
        return $"Name: {Name}\nPrice: {Price:C}";
    }
}

// Step 2: Extend the Product class to concrete classes
public class Book : Product
{
    public string Author { get; set; }

    public override double CalculateTotalPrice(int quantity)
    {
        return Price * quantity * 1.1; // Include 10% sales tax
    }

    public override string DisplayProductDetails()
    {
        return base.DisplayProductDetails() + $"\nAuthor: {Author}";
    }
}

public class Electronic : Product
{
    public string Brand { get; set; }

    public override double CalculateTotalPrice(int quantity)
    {
        return Price * quantity * 1.1; // Include 10% tax
    }

    public override string DisplayProductDetails()
    {
        return base.DisplayProductDetails() + $"\nBrand: {Brand}";
    }
}

// Step 3: Create an interface called IPurchasable
public interface IPurchasable
{
    double CalculateTotalPrice(int quantity);
    string DisplayProductDetails();
    int Quantity { get; set; }
}

// Step 4: Implement the IPurchasable interface in concrete classes
public class BookPurchasable : IPurchasable
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Author { get; set; }
    public int Quantity { get; set; }

    public double CalculateTotalPrice(int quantity)
    {
        return Price * quantity * 1.1;
    }

    public string DisplayProductDetails()
    {
        return $"Name: {Name}\nPrice: {Price:C}\nAuthor: {Author}\nQuantity: {Quantity}";
    }
}


public class ElectronicPurchasable : IPurchasable
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Brand { get; set; }
    public int Quantity { get; set; }

    public double CalculateTotalPrice(int quantity)
    {
        return Price * quantity * 1.1; // Include 10% tax
    }

    //Step 5: Create the output to display the product details on the screen
    public string DisplayProductDetails()
    {
        return $"Name: {Name}\nPrice: {Price:C}\nBrand: {Brand}\nQuantity: {Quantity}";
    }
}

// Step 6: Demonstrate the usage of Product classes and IPurchasable interface in Main
class AbstractShoppingCartSystem
{
    static void Main(string[] args)
    {
        List<IPurchasable> products = new List<IPurchasable>();

        // Add some predefined products
        products.Add(new BookPurchasable()
        {
            Name = "Rejected Princesses",
            Price = 24.99,
            Author = "Jason Porath",
            Quantity = 3
        });

        products.Add(new ElectronicPurchasable()
        {
            Name = "Scarlett 8i6 Digital Interface",
            Price = 399.99,
            Brand = "Focusrite",
            Quantity = 2
        });

        Console.WriteLine("Product Options:");
        Console.WriteLine("=================");
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] {products[i].DisplayProductDetails()}");
        }
        Console.WriteLine();

        Console.WriteLine("Select a Product:");
        Console.WriteLine("=================");
        Console.Write("Enter the product number to select: ");
        int productNumber = int.Parse(Console.ReadLine());

        if (productNumber < 1 || productNumber > products.Count)
        {
            Console.WriteLine("Invalid product number. Exiting the program.");
            return;
        }

        IPurchasable selectedProduct = products[productNumber - 1];

        Console.WriteLine();
        Console.WriteLine("Selected Product Details:");
        Console.WriteLine("=================");
        Console.WriteLine(selectedProduct.DisplayProductDetails());

        Console.Write("Enter the quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        selectedProduct.Quantity = quantity;

        Console.WriteLine();
        Console.WriteLine("Updated Product Details:");
        Console.WriteLine("=================");
        Console.WriteLine(selectedProduct.DisplayProductDetails());
        Console.WriteLine($"Total Price for {quantity} items (including tax): {selectedProduct.CalculateTotalPrice(quantity):C}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}


