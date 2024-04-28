using System;
using System.Globalization;
using System.Collections.Generic; 

class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number list, and type 0 when finish");
        List<int> numbers = new List<int>();

        int userNumber = -1; 
        int sum = 0;
        while (userNumber != 0) 
        {
            userNumber = int.Parse(Console.ReadLine()); 
            // numbers.Add(userNumber); 

            if (userNumber!= 0) {
                numbers.Add(userNumber); 
            }
        }

        foreach (int number in numbers) { 
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Determine the average of the number 
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Determine the max and minimum number

         int max = numbers[0];
         int min = numbers[0];
    
    foreach(int number in numbers) { 
        if(number > max) { 
            max = number;
        }
        if (number < min)  {
            min = number;
        }
    }
    Console.WriteLine($"The Maximum number is: {max}");
    Console.WriteLine($"The Minimum number is: {min}");

    numbers.Sort(); 

    Console.WriteLine("The sorted numebers are: \n");
    foreach(int number in numbers) { 
        Console.WriteLine($"{number}");
    }
    }
    
}