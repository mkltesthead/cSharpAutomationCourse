using System;
using System.Collections;
using System.Collections.Generic;

class LoopingWithCollections
{
    static void Main()
    {
        LoopingWithCollections app = new LoopingWithCollections();

        HashSet<string> myHashSet = new HashSet<string>()
        {
            "Alice",
            "Bob",
            "Charlie"
        };
        app.displayCollection(myHashSet);

        List<int> myList = new List<int>()
        {
            10,
            20,
            30,
            40
        };
        app.displayCollection(myList);

        LinkedList<string> myLinkedList = new LinkedList<string>();
        myLinkedList.AddLast("Shirt");
        myLinkedList.AddLast("Shoes");
        myLinkedList.AddLast("Hat");
        app.displayCollection(myLinkedList);

        Dictionary<string, string> myDictionary = new Dictionary<string, string>()
        {
            { "John", "john@example.com" },
            { "Alice", "alice@example.com" },
            { "Bob", "bob@example.com" }
        };
        app.displayCollection(myDictionary);

        /*
        // DEMO HASHSET: Create a HashSet to store names
        Console.WriteLine("HashSet:");
        Console.WriteLine("Size of the HashSet: " + myHashSet.Count);
        Console.WriteLine("HashSet contains Bob: " + myHashSet.Contains("Bob"));

        Console.WriteLine("Elements in the HashSet:");
        foreach (string name in myHashSet)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        // DEMO LIST: Create an ArrayList to store integers
        Console.WriteLine("ArrayList:");
        Console.WriteLine("Size of the ArrayList: " + myList.Count);
        Console.WriteLine("Element at index 2: " + myList[2]);

        myList[1] = 50;

        Console.WriteLine("Removing: " + myList[3]);
        myList.RemoveAt(3);

        Console.WriteLine("Elements in the ArrayList:");
        foreach (int number in myList)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        // DEMO LINKEDLIST: Create a LinkedList to represent a shopping cart
        Console.WriteLine("LinkedList:");
        Console.WriteLine("Items in the shopping cart:");
        foreach (string item in myLinkedList)
        {
            Console.WriteLine(item);
        }

        myLinkedList.Remove("Shoes");

        Console.WriteLine("Last Item in Cart: " + myLinkedList.Last.Value);
        Console.WriteLine("First Item in Cart: " + myLinkedList.First.Value);

        Console.WriteLine("Shopping cart contains Hat: " + myLinkedList.Contains("Hat"));

        Console.WriteLine("Updated items in the shopping cart:");
        foreach (string item in myLinkedList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        // DEMO DICTIONARY: Create a Dictionary to represent a contact list
        Console.WriteLine("Dictionary:");
        Console.WriteLine("Contacts in the contact list:");
        foreach (KeyValuePair<string, string> entry in myDictionary)
        {
            Console.WriteLine("Name: " + entry.Key + ", Email: " + entry.Value);
        }

        Console.WriteLine();

        // DEMO LOOPS:
        Console.WriteLine("Loops:");

        Console.WriteLine("Iterator method While loop output");
        var iterator = myHashSet.GetEnumerator();
        while (iterator.MoveNext())
        {
            Console.WriteLine(iterator.Current);
        }

        Console.WriteLine("For loop output");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine(myList[i]);
        }

        Console.WriteLine("Enhanced for loop output");
        foreach (string name in myHashSet)
        {
            Console.WriteLine("Name: " + name);
        }
        */

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    public void displayCollection(object myCollection)
    {
        if (myCollection is IEnumerable)
        {
            Console.WriteLine("While loop output");
            var iterator = ((IEnumerable)myCollection).GetEnumerator();
            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }
            Console.WriteLine();
        }

        if (myCollection is List<int>)
        {
            Console.WriteLine("For loop output");
            for (int i = 0; i < ((List<int>)myCollection).Count; i++)
            {
                Console.WriteLine(((List<int>)myCollection)[i]);
            }
            Console.WriteLine();
        }

        if (myCollection is IEnumerable)
        {
            Console.WriteLine("Foreach loop output");
            foreach (var name in ((IEnumerable)myCollection))
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }
    }
}
