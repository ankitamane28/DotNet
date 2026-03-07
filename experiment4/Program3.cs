//activity3  replace methods with lambda expressions

using System;

class Program
{
    static void Main()
    {
        // Using lambda expressions to replace methods
        Func<int, int, int> add = (a, b) => a + b; //this line defines a lambda expression for addition and assigns it to a Func delegate
        Func<int, int, int> subtract = (a, b) => a - b;
        Func<int, int, int> multiply = (a, b) => a * b;
        Func<int, int, int> divide = (a, b) => a / b;

        Console.WriteLine("Addition: " + add(10, 5));       // Output: 15
        Console.WriteLine("Subtraction: " + subtract(10, 5)); // Output: 5
        Console.WriteLine("Multiplication: " + multiply(10, 5)); // Output: 50
        Console.WriteLine("Division: " + divide(10, 5));     // Output: 2
    }
}
