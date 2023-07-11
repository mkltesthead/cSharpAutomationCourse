using System;
using System.Text;

class StringBuilderDemo
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Read ");

        sb.Append("Rejected Princesses");

        string result = sb.ToString();
        Console.WriteLine(result);

        sb.Insert(5, "Jason Porath's");

        string result2 = sb.ToString();
        Console.WriteLine(result2);

        sb.Replace("Read ", "Check Out ");
        sb.Remove(9, 15);

        string result3 = sb.ToString();
        Console.WriteLine(result3);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
