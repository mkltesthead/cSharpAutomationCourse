using System;
public class catClassExampleConstructor
{
    public static void Main(string[] args)
    {
        // Create a cat object using the default constructor
        Cat defaultCat = new Cat();
        Console.WriteLine("Default Cat:");
        Console.WriteLine($"Name: {defaultCat.Name}");
        Console.WriteLine($"Age: {defaultCat.Age}");
        Console.WriteLine($"Breed: {defaultCat.Breed}");
        Console.WriteLine();

        // Create a cat object using the parameterized constructor
        Cat customCat = new Cat("Whiskers", 3, "Persian");
        Console.WriteLine("Custom Cat:");
        Console.WriteLine($"Name: {customCat.Name}");
        Console.WriteLine($"Age: {customCat.Age}");
        Console.WriteLine($"Breed: {customCat.Breed}");
        Console.WriteLine();

        // Call the cat's methods
        defaultCat.Meow();
        customCat.Sleep();
        defaultCat.Sleep();
        customCat.Meow();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

public class Cat
{
    // Instance variables
    public string Name;
    public int Age;
    public string Breed;

    // Default constructor
    public Cat()
    {
        // Initialize with default values
        Name = "Default";
        Age = 0;
        Breed = "Unknown";
    }

    // Parameterized constructor
    public Cat(string name, int age, string breed)
    {
        // Initialize with specific values
        Name = name;
        Age = age;
        Breed = breed;
    }

    // Methods
    public void Meow()
    {
        Console.WriteLine("Meow! Meow!");
    }

    public void Sleep()
    {
        Console.WriteLine("Zzzz... Zzzz...");
    }
}
