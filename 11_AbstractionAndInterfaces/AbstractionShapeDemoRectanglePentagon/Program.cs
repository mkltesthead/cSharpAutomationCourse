using System;

public abstract class Shape
{
    public abstract double CalculateArea();

    public static void Print()
    {
        Console.WriteLine("I am a shape!");
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public override double CalculateArea()
    {
        return length * width;
    }

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

public class Pentagon : Shape
{
    private double sideLength;

    public Pentagon(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public override double CalculateArea()
    {
        return 1.72048 * sideLength * sideLength;
    }

    public double SideLength
    {
        get { return sideLength; }
        set { sideLength = value; }
    }
}

public class ShapeTester
{
    public static void Main()
    {
        Console.WriteLine("Choose a shape: ");
        Console.WriteLine("1. Rectangle");
        Console.WriteLine("2. Pentagon");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(length, width);
            Shape.Print();
            Console.WriteLine("Area of rectangle: " + rectangle.CalculateArea());
        }
        else if (choice == 2)
        {
            Console.Write("Enter the length of a side of the pentagon: ");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            Pentagon pentagon = new Pentagon(sideLength);
            Shape.Print();
            Console.WriteLine("Area of pentagon: " + pentagon.CalculateArea());
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
