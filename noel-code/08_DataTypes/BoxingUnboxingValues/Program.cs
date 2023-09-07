using System;

class BoxingUnboxingValues
{
    static void Main(string[] args)
    {
        // Boxing example
        int number = 42; // Value type
        object boxedNumber = number; // Boxing: Value type to reference type

        Console.WriteLine("Boxing example:");
        Console.WriteLine("Original number: " + number);
        Console.WriteLine("Boxed number: " + boxedNumber);
        Console.WriteLine();

        // Unboxing example
        int unboxedNumber = (int)boxedNumber; // Unboxing: Reference type to value type

        Console.WriteLine("Unboxing example:");
        Console.WriteLine("Unboxed number: " + unboxedNumber);
        Console.WriteLine();

        // Nullable value types example
        int? nullableNumber = null; // Nullable value type

        Console.WriteLine("Nullable value type example:");
        Console.WriteLine("Nullable number: " + nullableNumber); // Prints null
        Console.WriteLine("Nullable number has value? " + nullableNumber.HasValue); // False
        Console.WriteLine();

        nullableNumber = 10;
        Console.WriteLine("Nullable number: " + nullableNumber); // Prints 10
        Console.WriteLine("Nullable number has value? " + nullableNumber.HasValue); // True

        int regularNumber = nullableNumber.Value; // Accessing the value using .Value property

        Console.WriteLine("Regular number: " + regularNumber);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}
