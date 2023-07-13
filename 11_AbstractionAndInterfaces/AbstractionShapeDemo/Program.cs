using System;

public abstract class Shape
{
    // Abstract method
    public abstract double CalculateArea();

    // Non-abstract method
    public static void Print()
    {
        Console.WriteLine("I am a shape!");
    }
}

public class Rectangle : Shape
{
    // Fields
    private double length;
    private double width;

    // Constructor
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    // Implementing abstract method
    public override double CalculateArea()
    {
        return length * width;
    }

    // Getters and setters
    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }
}

public class ShapeTester
{
    public static void Main()
    {
        // Prompt the user to enter the length and width of the rectangle
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Create an instance of Rectangle
        Rectangle rectangle = new Rectangle(length, width);

        // Call inherited method
        Shape.Print();

        // Call implemented abstract method
        Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());
        Console.WriteLine("Press any Key to Continue");
        Console.ReadKey();
    }
}