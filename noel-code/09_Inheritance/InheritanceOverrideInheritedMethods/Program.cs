using System;

public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a generic shape.");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        shape.Draw();   // Output: Drawing a generic shape.

        Circle circle = new Circle();
        circle.Draw();  // Output: Drawing a circle.

        Shape circleAsShape = new Circle();
        circleAsShape.Draw();  // Output: Drawing a circle.

        Console.ReadKey();
    }
}


