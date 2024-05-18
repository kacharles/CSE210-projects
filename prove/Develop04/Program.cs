using System;

class Program
{   
    
    static void Main(string[] args)
    {       
        int choice;
        do{ 
            Console.WriteLine("Menu");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflecting Activity");
            Console.WriteLine(" 3. Start Listing Activity"); 
            Console.WriteLine(" 4. Journal Activity");
            Console.WriteLine(" 5. Quit");
            Console.WriteLine($"Select a choice from the menu ");
            Console.Write(">");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1) { 
                Console.WriteLine("Breathing Activity\n");
                BreathingActivity ba = new BreathingActivity(); 
                ba.Run();  
            }
            else if (choice == 2) { 
                Console.WriteLine("Listing Activity\n");
                ReflectingActivity ra = new ReflectingActivity();
                ra.Run();

            }
            else if(choice == 3) { 
                Console.WriteLine("Listing Activity");
                ListingActivity la = new ListingActivity();
                la.Run();
            }
            
            else if(choice == 4) { 
                Console.WriteLine("Journal Activity");
                JournalActivity ja = new JournalActivity();
                ja.Run();
            }
            else { 
                Console.WriteLine("GoodBye!"); 
            }
        }while(choice != 5); 
    }
}