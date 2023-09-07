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

public class InheritancePeopleInSchool
{
    public static void Main(string[] args)
    {
        Person person = new Person();
        person.Name = "John";
        person.PersonID = "123";
        person.Introduce();

        Employee emp = new Employee();
        emp.Name = "Alice";
        emp.PersonID = "456";
        emp.Title = "Manager";
        emp.Salary = 5000;
        emp.Introduce();
        emp.Work();

        Teacher teacher = new Teacher();
        teacher.Name = "Sarah";
        teacher.PersonID = "789";
        teacher.Title = "Math Teacher";
        teacher.Salary = 4000;
        teacher.Classes = new List<string> { "Algebra", "Geometry" };
        teacher.Introduce();
        teacher.Work();
        teacher.Teach();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
