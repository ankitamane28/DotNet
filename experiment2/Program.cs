using System;

class Student
{
    // Data Members (private for encapsulation)
    private int rollNo;
    private string name;

    // Method to set values
    public void SetData(int r, string n)
    {
        rollNo = r;
        name = n;
    }

    // Method to display values
    public void DisplayData()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating object
        Student s1 = new Student();

        // Calling method to set data
        s1.SetData(1, "Ankita");

        // Calling method to display data
        Console.WriteLine("Student Details:");
        s1.DisplayData();

        Console.ReadLine();
    }
}