using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // DEMO HASHSET: Create a HashSet to store names
        DemoHashSet();

        Console.WriteLine("*********************************************");

        // Create an ArrayList to store integers
        DemoArrayList();

        Console.WriteLine("*********************************************");

        // Create a LinkedList to represent a shopping cart
        DemoLinkedList();

        Console.WriteLine("*********************************************");

        // Create a Dictionary to represent a contact list
        DemoDictionary();

        Console.WriteLine("*********************************************");

        // Create an immutable collection using List.Of method
        DemoImmutableList();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    public static void DemoHashSet()
    {
        HashSet<string> namesSet = new HashSet<string>();

        // Add elements to the HashSet
        namesSet.Add("Alice");
        namesSet.Add("Bob");
        namesSet.Add("Charlie");
        namesSet.Add("Alice"); // Adding a duplicate element (ignored in a HashSet)

        // Display the size of the HashSet
        Console.WriteLine("Size of the HashSet: " + namesSet.Count);

        // Check if an element is present in the HashSet
        bool containsBob = namesSet.Contains("Bob");
        Console.WriteLine("HashSet contains Bob: " + containsBob);

        // Remove an element from the HashSet
        namesSet.Remove("Charlie");

        // Display all elements in the HashSet
        Console.WriteLine("Elements in the HashSet:");
        foreach (var name in namesSet)
        {
            Console.WriteLine(name);
        }
    }

    public static void DemoArrayList()
    {
        List<int> numbersList = new List<int>();

        // Add elements to the List
        numbersList.Add(10);
        numbersList.Add(20);
        numbersList.Add(30);
        numbersList.Add(40);
        numbersList.Add(10); // Adding a duplicate to show the support for having duplicate values in a list

        // Display the size of the List
        Console.WriteLine("Size of the List: " + numbersList.Count);

        // Access an element at a specific index
        int elementAtIndex2 = numbersList[2];
        Console.WriteLine("Element at index 2: " + elementAtIndex2);

        // Modify an element at a specific index
        numbersList[1] = 50;

        // Remove an element at a specific index
        Console.WriteLine("Removing: " + numbersList[3]);
        numbersList.RemoveAt(3);

        // Display all elements in the List
        Console.WriteLine("Elements in the List:");
        foreach (var number in numbersList)
        {
            Console.WriteLine(number);
        }

        // Display a sublist of items from the List
        Console.WriteLine("Sublist of items from the List:");
        List<int> sublist = numbersList.GetRange(2, 2);
        foreach (var number in sublist)
        {
            Console.WriteLine(number);
        }
    }

    public static void DemoLinkedList()
    {
        LinkedList<string> shoppingCart = new LinkedList<string>();

        // Add items to the shopping cart
        shoppingCart.AddLast("Shirt");
        shoppingCart.AddLast("5");
        shoppingCart.AddLast("Shoes");
        shoppingCart.AddLast("Hat");
        shoppingCart.AddLast("10");

        // Display the items in the shopping cart
        Console.WriteLine("Items in the shopping cart:");
        foreach (var item in shoppingCart)
        {
            Console.WriteLine(item);
        }

        // Remove an item from the shopping cart
        shoppingCart.Remove("Hat");

        // Check if an item is in the shopping cart
        bool containsHat = shoppingCart.Contains("Hat");
        Console.WriteLine("Shopping cart contains Hat: " + containsHat);

        // Manually find the index of an item in the shopping cart
        int jeansIndex = FindLinkedListIndex(shoppingCart, "Jeans");
        Console.WriteLine("Index of Jeans in the shopping cart: " + jeansIndex);

        // Modify an item in the shopping cart
        shoppingCart.AddFirst("T-Shirt");
        shoppingCart.RemoveLast();

        // Display the updated items in the shopping cart
        Console.WriteLine("Updated items in the shopping cart:");
        foreach (var item in shoppingCart)
        {
            Console.WriteLine(item);
        }
    }

    public static int FindLinkedListIndex<T>(LinkedList<T> linkedList, T item)
    {
        int index = 0;
        foreach (var listItem in linkedList)
        {
            if (EqualityComparer<T>.Default.Equals(listItem, item))
            {
                return index;
            }
            index++;
        }
        return -1; // Item not found
    }


    public static void DemoDictionary()
    {
        Dictionary<string, string> contactList = new Dictionary<string, string>();

        // Add contacts to the Dictionary
        contactList["John"] = "john@example.com";
        contactList["Alice"] = "alice@example.com";
        contactList["Bob"] = "bob@example.com";
        contactList["Jacob"] = "jacob@mmc.com";

        // Display all contacts in the contact list
        Console.WriteLine("Contacts in the contact list:");
        foreach (var entry in contactList)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }

        // Accessing a specific contact's email
        string johnEmail = contactList["John"];
        Console.WriteLine("Email of John: " + johnEmail);

        // Check if a contact is present in the contact list
        bool containsAlice = contactList.ContainsKey("Alice");
        Console.WriteLine("Contact list contains Alice: " + containsAlice);

        // Remove a contact from the contact list
        contactList.Remove("Bob");

        // Display the updated contacts in the contact list
        Console.WriteLine("Updated contacts in the contact list:");
        foreach (var entry in contactList)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
    }

    public static void DemoImmutableList()
    {
        List<string> fruitsList = new List<string> { "Apple", "Banana", "Orange" };

        // Display the elements in the List
        Console.WriteLine("Elements in the List:");
        foreach (var fruit in fruitsList)
        {
            Console.WriteLine(fruit);
        }
    }
}
