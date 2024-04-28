// Write a program to determine a letter grade 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grades to determine if you pass the class:"); 
        int getGrades = int.Parse(Console.ReadLine()); 

        string letterGrades; 

        if (getGrades >= 90) { 
            letterGrades = "A"; 
        }
        else if (getGrades >= 80) { 
            letterGrades = "B"; 
        }
        else if (getGrades >= 70){ 
            letterGrades = "C";
        }
        else if (getGrades >= 60) { 
            letterGrades = "D";
        }
        else { 
            letterGrades = "F";
        }

        if (getGrades >= 60 & getGrades < 100 & (getGrades % 10 < 3) ) {
                letterGrades += "-";
        }
        else if (getGrades >= 60 & getGrades < 90 & (getGrades % 10 >= 7)) { 
            letterGrades += "+";
        }
    
        Console.Write($"Your grade is {letterGrades}.\n");
        if (getGrades >= 70) {
            Console.Write("You pass! Congratulations.");
        }
        else { 
            Console.Write("You failed! Please try again.");
        }

    }

}