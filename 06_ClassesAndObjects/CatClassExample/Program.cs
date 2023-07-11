using System;

public class catClassProgramExample
{
    public static void Main(string[] args)
    {
        // Create a new instance of Cat
        Cat myCat = new Cat();

        // Set the cat's attributes
        myCat.Name = "Whiskers";
        myCat.Age = 3;
        myCat.Breed = "Persian";

        // Access the cat's attributes
        Console.WriteLine($"Name: {myCat.Name}");
        Console.WriteLine($"Age: {myCat.Age}");
        Console.WriteLine($"Breed: {myCat.Breed}");

        // Call the cat's methods
        myCat.Meow();
        myCat.Sleep();

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
