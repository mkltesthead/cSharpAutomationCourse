using System;
using System.Collections.Generic;

public interface ITeachable
{
    void Teach();
}

public class Person
{
    public string Name { get; set; }
    public string PersonID { get; set; }

    public void Introduce()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }
}

public class Employee : Person
{
    public string Title { get; set; }
    public float Salary { get; set; }

    public void Work()
    {
        Console.WriteLine(Name + " is working as a " + Title);
    }
}

public class Teacher : Employee, ITeachable
{
    public List<string> Classes { get; set; }

    public void Teach()
    {
        Console.WriteLine(Name + " is teaching the following classes:");
        foreach (string className in Classes)
        {
            Console.WriteLine("- " + className);
        }
    }
}

public class InheritanceChainOfExample
{
    public static void Main(string[] args)
    {
        // Person person = new Person();
        // Employee emp = new Employee();

        Teacher teacher = new Teacher();
        teacher.Name = "Georgia";
        Console.WriteLine("Hello! I'm a teacher and my name is " + teacher.Name);

        Teacher teacher2 = new Teacher();
        teacher2.Name = "Sarah";
        teacher2.PersonID = "789";
        teacher2.Title = "Math Teacher";
        teacher2.Salary = 4000;
        teacher2.Classes = new List<string> { "Algebra", "Geometry" };
        teacher2.Introduce();
        teacher2.Work();
        teacher2.Teach();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}