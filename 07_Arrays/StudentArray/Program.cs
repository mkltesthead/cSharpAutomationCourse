using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        // Create an array of Student objects
        Student[] students = new Student[3];

        // Initialize each element of the students array with Student objects
        students[0] = new Student { Name = "Alice", Age = 20 };
        students[1] = new Student { Name = "Bob", Age = 21 };
        students[2] = new Student { Name = "Charlie", Age = 19 };

        // Iterate over the students array using an enhanced for loop
        foreach (Student student in students)
        {
            // Access the details (name and age) of each student object using the getter methods
            string name = student.Name;
            int age = student.Age;

            // Print the details to the console
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
