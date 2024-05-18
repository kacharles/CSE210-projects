using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment asign = new Assignment("Charles A. Koenig", "Programming with Classes");
        Console.WriteLine(asign.GetSummary());
    }
} 