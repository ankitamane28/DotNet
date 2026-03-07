// Activity2  Multicast delegate example

using System;

class Program
{
    public delegate void Notify(string message);
    public static void SendEmail(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
    public static void SendSMS(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Activity2  Multicast delegate");
        Notify notifyDelegate = SendEmail;
        notifyDelegate += SendSMS;
        notifyDelegate("Hello, this is a multicast delegate example");

    }
}