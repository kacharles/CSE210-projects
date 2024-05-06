using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    
    static void Main(string[] args)

    {
        Fraction f1 = new Fraction(); 
        Console.WriteLine($"String: {f1.GetFraction()}"); 
        Console.WriteLine($"Decimal: {f1.GetDecimalValue()}");

        Fraction f2 = new Fraction(5); 
        Console.WriteLine($"String: {f2.GetFraction()}"); 
        Console.WriteLine($"Decimal: {f2.GetDecimalValue()}");

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"String: {f3.GetFraction()}"); 
        Console.WriteLine($"Decimal: {f3.GetDecimalValue()}");

        Fraction f4 = new Fraction(1, 3);  
        Console.WriteLine($"String: {f4.GetFraction()}"); 
        Console.WriteLine($"Decimal: {f4.GetDecimalValue()}");
        

        


        
    }

}