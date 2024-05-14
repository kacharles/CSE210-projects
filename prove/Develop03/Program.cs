using System;
using System.IO; 
using System.Buffers; 
using System.Globalization;
using System.Configuration;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string book; 
        int chapter; 
        int startVerse;
        int endVerse; 
        string text; 
        // Ask the user for input
        Console.WriteLine("Enter Scripture Reference and text you would like to memorize. \n");
        Console.WriteLine("Enter the book: "); 
        book = Console.ReadLine();
        Console.WriteLine("Enter the chapter: "); 
        chapter = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the verse: "); 
        startVerse = int.Parse(Console.ReadLine()); 
        Console.Write("Enter the end verse. Type zero if there's no end verse"); 
        endVerse = int.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter the text: "); 
        text = Console.ReadLine();

        Reference r; 
        //Instanciate a new reference and pass the user input
        if (endVerse == 0) {
          r = new Reference(book, chapter, startVerse);
        }
        else { 
          r = new Reference(book, chapter, startVerse, endVerse);
        }
        
        // string words = "if my people who are called by my name"; 
        Scripture s = new Scripture(r, text);


        //Instanciate a new Scripture and pass the reference object and the 
        //text enter by the user; 
        
        // A userput to control the random words being replace by dash or stroke
        string ctrInput = ""; 

        // a while loop to hide a word and replace it with an underscore 
        // and display the word 

        while(ctrInput != "quit") {
        Console.WriteLine(s.GetDisplayText()); 
        ctrInput = Console.ReadLine();
        s.HideRandomWords(); 
        Console.Clear(); 
        }
         
    }
}
