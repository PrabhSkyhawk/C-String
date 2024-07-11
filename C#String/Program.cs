using System;

class Program
{
  
    static void Main(string[] args)
    {

        int n1 = 10;
        int n2 = 20;
        Console.WriteLine($"The sum of {n1}and {n2}is {n1 + n2}");
        Console.WriteLine(".................................");
                
        int n3 = 10;
        int n4 = 20;
        string s;
        s = $"the sum of {n3} and {n4} is {n3 + n4}";
        Console.WriteLine(s);
        Console.WriteLine("..........................");
           
        string name = "Prabhjot Singh";
        int age = 25;

        Console.WriteLine($"{name} is {age} years old");

        DateTime now = DateTime.Now;
        Console.WriteLine($"Today is {now.DayOfWeek}, it's {now:HH:mm}");             
    }
    static void FormatString(string[] args)       
    {
       DateTime now = DateTime.Now;

       Console.WriteLine($"Short date: {now:d}");
       Console.WriteLine($"Short date: {now:d}");
       Console.WriteLine($"Long date: {now:D}");
       Console.WriteLine($"Short time: {now:t}");
       Console.WriteLine($"Long time: {now:T}");
       Console.WriteLine($"Month: {now:M}");
       Console.WriteLine($"Year: {now:Y}");
    }
}
