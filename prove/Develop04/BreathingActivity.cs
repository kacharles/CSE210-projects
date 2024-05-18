public class BreathingActivity:Activity { 
    
    public BreathingActivity():base() { 
        _name = "Brething Activity"; 
        _description = "This activity will help you relax by walking" +
        "your through breathing in and out slowly. Clear your mind and " +
        "focus on your breathing.";
    }

    public void Run() { 
        // changes the background and foreground color of the console.
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        
        //Call the DisplayStartingmessage Method to display the starting message
        DisplayStartingMessage(); 
        
        Console.WriteLine("Get ready...");

        //Call the spinner method to give the user time to prepare
        ShowSpinner(5); 
        DateTime startTime = DateTime.Now; 
        DateTime stopTime = startTime.AddSeconds(_duration);

        //The user is being prompted to carryout the breathing exercise
        do { 

            Console.Write($"Breathe in...");
            ShowCountDownTimer(5);
            Console.WriteLine(); 
            Console.Write($"Breathe Out..."); 
            ShowCountDownTimer(5); 
            Console.WriteLine("\n");
        }while(DateTime.Now < stopTime); 

        //The user finish the breathing activity
        Console.WriteLine("Well done!"); 
        ShowSpinner(5); 
        //The user is prompted with a congratulatory message. 
        Console.Write($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.Clear(); 
    }
}