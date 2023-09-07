using System;

class catWithProperties
{
    static void Main(string[] args)
    {
        Cat myCat = new Cat();

        Console.Write("Enter cat's name: ");
        myCat.Name = Console.ReadLine();

        Console.Write("Enter cat's age: ");
        int age = int.Parse(Console.ReadLine());
        myCat.Age = age;

        Console.WriteLine("\nCat Information:");
        Console.WriteLine("Name: " + myCat.Name);
        Console.WriteLine("Age: " + myCat.Age);

                Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

public class Cat
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                // Console.WriteLine("Age cannot be negative.")
                throw new ArgumentException("Age cannot be negative.");
            }
        }
    }
}

