using System;

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class InheritanceInterfaceDemo
{
    static void Main(string[] args)
    {
        IShape rectangle = new Rectangle { Width = 5, Height = 3 };
        Console.WriteLine("Rectangle area: " + rectangle.CalculateArea());
        Console.WriteLine("Rectangle perimeter: " + rectangle.CalculatePerimeter());

        IShape circle = new Circle { Radius = 4 };
        Console.WriteLine("Circle area: " + circle.CalculateArea());
        Console.WriteLine("Circle circumference: " + circle.CalculatePerimeter());

        Console.ReadKey();
    }
}
