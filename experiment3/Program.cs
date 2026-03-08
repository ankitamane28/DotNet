using System;

// Class responsible for storing student data
class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }

    public Student(int rollNo, string name)
    {
        RollNo = rollNo;
        Name = name;
    }
}

// Class responsible only for printing student details
class StudentPrinter
{
    public void Print(Student student)
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("Roll No: " + student.RollNo);
        Console.WriteLine("Name: " + student.Name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(1, "Ankita");

        StudentPrinter printer = new StudentPrinter();
        printer.Print(s1);

        Console.ReadLine();
    }
}