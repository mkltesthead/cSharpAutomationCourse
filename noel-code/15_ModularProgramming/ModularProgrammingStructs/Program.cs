using System;

// Define a struct for a 2D Point
struct Point
{
    public int X;
    public int Y;

    // Constructor to initialize the point
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Method to display the point's coordinates
    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y})");
    }
}

class Program
{
    static void Main()
    {
        // Create two Point instances using the struct
        Point point1 = new Point(3, 5);
        Point point2 = new Point(7, 9);

        // Display the points
        point1.Display();
        point2.Display();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

