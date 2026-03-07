using System;

class Program
{
    static void Main()
    {
        Action greet = () => Console.WriteLine("Button Clicked!");

        greet();
    }
}