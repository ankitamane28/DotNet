//Activity6 what is LINQ Query

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 25, 30, 45, 50 };

        // LINQ Query
        var result = numbers.Where(n => n > 30);
        Console.WriteLine("Activity6 what is LINQ Query");
        Console.WriteLine("Numbers greater than 30:");

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}