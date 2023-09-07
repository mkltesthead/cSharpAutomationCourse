using System;

public class rectangleExample
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());

        Rectangle rectangle = new Rectangle(length, width);
        GeometryUtility.PrintRectangleInfo(rectangle);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

public class Rectangle
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
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

    public double GetArea()
    {
        return length * width;
    }

    public double GetPerimeter()
    {
        return 2 * (length + width);
    }
}

public class GeometryUtility
{
    public static void PrintRectangleInfo(Rectangle rectangle)
    {
        Console.WriteLine("Length: " + rectangle.Length);
        Console.WriteLine("Width: " + rectangle.Width);
        Console.WriteLine("Area: " + rectangle.GetArea());
        Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());
    }
}
