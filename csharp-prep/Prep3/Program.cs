using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random(); 
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1; 

        int count = 0;
        while (guess != magicNumber) { 
            Console.WriteLine("Guess the magic number"); 
            guess = int.Parse(Console.ReadLine());


            if(guess > magicNumber) {
                Console.WriteLine("Higher");
            }

            else if (guess < magicNumber ){ 
                Console.WriteLine("Lower");
            }
            

            else { 
                Console.WriteLine("You have guess it");

            }
            count += 1;
          

        }
          Console.WriteLine($"You have guess {count} times");
    }
}