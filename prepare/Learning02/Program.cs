using System;
using System.Security.Cryptography;
using System.IO;

class Program
{

    
     
    public void DisplayMenu() { 
        Console.WriteLine("Please select one of the following:\n "); 
        Console.WriteLine("1. Write\n2. Display\n3. Save\n4. Load\n5. Quit"); 
        Console.WriteLine("Program Continues..."); 
    }
    static void Main(string[] args)
    {
        

        Program p = new Program();
        int userInput = 0;
        Journal jl = new Journal(); 
        List<Entry> journalEntry = new List<Entry>(); 
        
        // string filename; 
        
        

        while (userInput != 5) {
            p.DisplayMenu(); 
            userInput = int.Parse(Console.ReadLine()); 
            PromptGenerator pg = new PromptGenerator(); 
            Entry entry = new Entry(); 
            journalEntry = jl._entries;

        
        if (userInput == 1) { 

        string prompt = pg.DisplayPrompt(); 
        Console.Write(prompt); 
        string textEntry = Console.ReadLine(); 
        entry.SetEntry(prompt, textEntry); 
        entry.Display(); 
        jl.AddEntry(entry);
        }

        else if (userInput == 2) { 
            jl.DisplayAll();
        }

        else if (userInput == 3) { 
            // Console.Write("Please enter a file name: ");
            // filename = Console.ReadLine();
            Journal.SaveToFile(journalEntry);
            Console.WriteLine("The file has been saved..");
            
        }

        else if (userInput == 4) { 
            
            Console.WriteLine("Loading from file"); 
            Journal.LoadFromFile(); 
        }

        else { 
            Console.WriteLine("Thank you writing to your journal today!");
        }
        
        
        // userInput = int.Parse(Console.ReadLine()); 
        // Console.WriteLine("Welcome to the program..");
        // PromptGenerator pg = new PromptGenerator(); 
        // Entry entry = new Entry(); 
        // Journal jl = new Journal(); 
        // string prompt = pg.DisplayPrompt(); 
        // Console.Write(prompt); 

        // string textEntry = Console.ReadLine(); 
        // entry.SetEntry(prompt, textEntry); 
        // entry.Display(); 
        // jl.AddEntry(entry); 
        
        // string prompt2 = pg.DisplayPrompt(); 

        // Console.Write(prompt2); 
        // string textEntry2 = Console.ReadLine(); 
        // entry.SetEntry(prompt2, textEntry2); 
        // jl.AddEntry(entry);

        // jl.DisplayAll(); 
                

    } 
    }
}

