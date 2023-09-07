using System;

public class rectangleExampleReturnObject
{
    public static void Main(string[] args)
    {
        double length, width;

        Console.WriteLine("Enter the length of the rectangle:");
        double.TryParse(Console.ReadLine(), out length);

        Console.WriteLine("Enter the width of the rectangle:");
        double.TryParse(Console.ReadLine(), out width);

        Rectangle rectangle = GeometryUtility.CreateRectangle(length, width);
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
    public static Rectangle CreateRectangle(double length, double width)
    {
        Rectangle rectangle = new Rectangle(length, width);
        return rectangle;
    }

    public static void PrintRectangleInfo(Rectangle rectangle)
    {
        Console.WriteLine("Length: " + rectangle.Length);
        Console.WriteLine("Width: " + rectangle.Width);
        Console.WriteLine("Area: " + rectangle.GetArea());
        Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());
    }
}