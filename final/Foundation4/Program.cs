using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling cyc = new Cycling("Cycling", 50);
        Console.WriteLine(cyc.GetSummary());
        Console.WriteLine();

        Running run = new Running("Running", 75, 10);
        Console.WriteLine(run.GetSummary());
        Console.WriteLine(); 

        Swimming swim = new Swimming("Swimming", 105); 
        Console.WriteLine(swim.GetSummary());
        

    }
}