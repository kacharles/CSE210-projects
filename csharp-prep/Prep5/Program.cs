using System;

class Program
{
    static void Main(string[] args)
    {
        // Functions in C#
        // Console.WriteLine("Hello Learning05 World!");
        WelcomeMessage(); 
        string userName = PromptUserName(); 
        int userNumber = PromptUserNumber();
        int squareNummber = SquareNummber(userNumber);
        DisplayResult(userName, squareNummber);
    }

    
    public static void WelcomeMessage() { 
        Console.WriteLine("Welcome to the program!");
    }

    public static string PromptUserName() { 
        Console.WriteLine("Please enter your name: ");
        string username; 
        username = Console.ReadLine(); 
        return username;
    }

    public static int PromptUserNumber() { 
        Console.WriteLine("Please enter your favorite number: ");
        int usernumber = int.Parse(Console.ReadLine());
        return usernumber;
    }

    public static int SquareNummber(int number) { 
        int numberSquare = number * number; 
        return numberSquare;
    }

    public static void DisplayResult(string name, int numbersquare) { 
        Console.Write($"{name}, the square of your number is {numbersquare}");

    }
}