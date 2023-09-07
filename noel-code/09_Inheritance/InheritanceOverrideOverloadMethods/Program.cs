using System;

public class Rectangle
{
    protected double length;
    protected double width;
    protected readonly double SIDES = 4;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public virtual double GetPerimeter()
    {
        return 2 * (length + width);
    }

    public void Print()
    {
        Console.WriteLine("I am a rectangle");
    }
}

public class Square : Rectangle
{
    public Square(double side) : base(side, side)
    {
    }

    public override double GetPerimeter()
    {
        return SIDES * length;
    }

    public void Print(string name)
    {
        Console.WriteLine("I am a " + name);
    }
}

public class InheritanceOverrideOverloadMethods
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(4, 6);
        rectangle.Print();

        Square square = new Square(5);
        square.Print();
        square.Print("square");

        Console.WriteLine("Rectangle perimeter: " + rectangle.GetPerimeter());
        Console.WriteLine("Square perimeter: " + square.GetPerimeter());

        Console.ReadKey();
    }
}
