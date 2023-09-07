using System;

class MyClass
{
    public int Number;

    public MyClass(int num)
    {
        Number = num;
    }
}

class Program
{
    static void Main()
    {
        // Stack Memory (Value Types)
        int a = 10; // 'a' is stored on the stack
        int b = a;  // 'b' is a copy of 'a' on the stack

        // Heap Memory (Reference Types)
        MyClass obj1 = new MyClass(20); // 'obj1' is a reference stored on the stack, pointing to an object on the heap
        MyClass obj2 = obj1;            // 'obj2' is another reference to the same object on the heap

        // Display initial values
        Console.WriteLine("Stack Memory (Value Types):");
        Console.WriteLine($"a: {a}, b: {b}");

        Console.WriteLine("\nHeap Memory (Reference Types):");
        Console.WriteLine($"obj1.Number: {obj1.Number}, obj2.Number: {obj2.Number}");

        // Modifying value types (stack memory)
        b = 30; // Modifying 'b' does not affect 'a' because they are independent copies in stack memory

        // Modifying reference types (heap memory)
        obj2.Number = 40; // Modifying 'obj2' will also affect 'obj1' as they both reference the same object on the heap

        // Display modified values
        Console.WriteLine("\nAfter Modifications:");
        Console.WriteLine($"a: {a}, b: {b}");
        Console.WriteLine($"obj1.Number: {obj1.Number}, obj2.Number: {obj2.Number}");

        // End of Main method (stack memory variables 'a' and 'b' go out of scope)
        // The Garbage Collector will automatically clean up objects on the heap that are no longer accessible.
    }
}
