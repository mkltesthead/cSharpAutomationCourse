using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> namesSet = new HashSet<string>()
            {
                "Alice",
                "Bob",
                "Charlie"
            };

        List<int> numbersList = new List<int>()
            {
                10,
                20,
                30,
                40
            };

        LinkedList<string> shoppingCart = new LinkedList<string>();
        shoppingCart.AddLast("Shirt");
        shoppingCart.AddLast("Shoes");
        shoppingCart.AddLast("Hat");

        Dictionary<string, string> contactList = new Dictionary<string, string>()
            {
                { "John", "john@example.com" },
                { "Alice", "alice@example.com" },
                { "Bob", "bob@example.com" }
            };

        // DEMO HASHSET: Create a HashSet to store names
        Console.WriteLine("HashSet:");
        Console.WriteLine("Size of the HashSet: " + namesSet.Count);
        Console.WriteLine("HashSet contains Bob: " + namesSet.Contains("Bob"));

        Console.WriteLine("Elements in the HashSet:");
        foreach (string name in namesSet)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        // DEMO LIST: Create an ArrayList to store integers
        Console.WriteLine("ArrayList:");
        Console.WriteLine("Size of the ArrayList: " + numbersList.Count);
        Console.WriteLine("Element at index 2: " + numbersList[2]);

        numbersList[1] = 50;

        Console.WriteLine("Removing: " + numbersList[3]);
        numbersList.RemoveAt(3);

        Console.WriteLine("Elements in the ArrayList:");
        foreach (int number in numbersList)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        // DEMO LINKEDLIST: Create a LinkedList to represent a shopping cart
        Console.WriteLine("LinkedList:");
        Console.WriteLine("Items in the shopping cart:");
        foreach (string item in shoppingCart)
        {
            Console.WriteLine(item);
        }

        shoppingCart.Remove("Shoes");

        Console.WriteLine("Last Item in Cart: " + shoppingCart.Last.Value);
        Console.WriteLine("First Item in Cart: " + shoppingCart.First.Value);

        Console.WriteLine("Shopping cart contains Hat: " + shoppingCart.Contains("Hat"));

        Console.WriteLine("Updated items in the shopping cart:");
        foreach (string item in shoppingCart)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        // DEMO DICTIONARY: Create a Dictionary to represent a contact list
        Console.WriteLine("Dictionary:");
        Console.WriteLine("Contacts in the contact list:");
        foreach (KeyValuePair<string, string> entry in contactList)
        {
            Console.WriteLine("Name: " + entry.Key + ", Email: " + entry.Value);
        }

        Console.WriteLine();

        // DEMO LOOPS:
        Console.WriteLine("Loops:");

        Console.WriteLine("Iterator method While loop output");
        var iterator = namesSet.GetEnumerator();
        while (iterator.MoveNext())
        {
            Console.WriteLine(iterator.Current);
        }

        Console.WriteLine("For loop output");
        for (int i = 0; i < numbersList.Count; i++)
        {
            Console.WriteLine(numbersList[i]);
        }

        Console.WriteLine("Enhanced for loop output");
        foreach (string name in namesSet)
        {
            Console.WriteLine("Name: " + name);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

