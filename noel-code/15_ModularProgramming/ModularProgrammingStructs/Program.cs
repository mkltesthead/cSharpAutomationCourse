using System;

// Define a struct for a 3D Point
struct Point
{
    public int X;
    public int Y;
    public int Z;

    // Constructor to initialize the point
    public Point(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    // Method to display the point's coordinates
    public void Display()
    {
        Console.WriteLine($"Point: ({X}, {Y}, {Z})");
    }
}

class Program
{
    static void Main()
    {
        // Create 8 Point instances using the struct
        Point point1 = new Point(0, 0, 0);
        Point point2 = new Point(0, 0, 1);
        Point point3 = new Point(0, 1, 0);
        Point point4 = new Point(0, 1, 1);
        Point point5 = new Point(1, 0, 0);
        Point point6 = new Point(1, 0, 1);
        Point point7 = new Point(1, 1, 0);
        Point point8 = new Point(1, 1, 1);

        // Display the points
        point1.Display();
        point2.Display();
        point3.Display();
        point4.Display();
        point5.Display();
        point6.Display();
        point7.Display();
        point8.Display();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}