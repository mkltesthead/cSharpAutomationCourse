using System;

class catConstructorOverload
{
    static void Main(string[] args)
    {
        // Create Cat objects using different constructors
        Cat cat1 = new Cat();
        Cat cat2 = new Cat("Whiskers");
        Cat cat3 = new Cat("Fluffy", 3);

        // Display cat information
        cat1.DisplayInfo();
        cat2.DisplayInfo();
        cat3.DisplayInfo();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

public class Cat
{
    // Instance variables
    private string name;
    private int age;

    // Default constructor
    public Cat()
    {
        name = "Unknown";
        age = 0;
    }

    // Constructor with name parameter
    public Cat(string catName)
    {
        name = catName;
        age = 0;
    }

    // Constructor with name and age parameters
    public Cat(string catName, int catAge)
    {
        name = catName;
        age = catAge;
    }

    // Method to display cat information
    public void DisplayInfo()
    {
        Console.WriteLine($"Cat Name: {name}");
        Console.WriteLine($"Cat Age: {age}");
    }
}
