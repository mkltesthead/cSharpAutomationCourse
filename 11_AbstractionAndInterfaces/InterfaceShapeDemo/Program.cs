using System;

public interface IShape
{
    void Draw();
}

public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}

public class InterfaceExample
{
    public static void Main()
    {
        IShape circle = new Circle();
        circle.Draw();

        IShape rectangle = new Rectangle();
        rectangle.Draw();

        Console.WriteLine("Press any key to exit");
        Console.ReadKey();
    }
}


