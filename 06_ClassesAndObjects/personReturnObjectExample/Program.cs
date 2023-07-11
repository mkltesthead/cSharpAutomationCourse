using System;

public class personReturnObjectExample
{
    public static void Main(string[] args)
    {
        PersonManager manager = new PersonManager();
        Person person = manager.CreatePerson("John Doe", 25);

        Console.WriteLine($"Name: {person.Name}");
        Console.WriteLine($"Age: {person.Age}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class PersonManager
{
    public Person CreatePerson(string name, int age)
    {
        Person person = new Person();
        person.Name = name;
        person.Age = age;
        return person;
    }
}