public class Activity { 

    // protected members variables that are accessed only in this class
    // and derived classes
    protected string _name;
    protected string _description; 
    protected int _duration; 

    // public constructor - initializes the protected date in the class
    public Activity() { 
        _name = ""; 
        _description = ""; 
        _duration = 0; 
    }

// Display a starting message for this activity and other classes in
// this program that derived this this classe
    public void DisplayStartingMessage() { 
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}"); 
        Console.WriteLine($"{_description}"); 
        //prompt for duration
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine()); 

    }

    // Displaying an ending message for this class and other classes that 
    // derived this class
    public void DisplayEndingMessage() { 

        Console.WriteLine("Well done!"); 

    }

    // A function that animates sequence of characters to a user indicating 
    // something is loading
    public void ShowSpinner(int seconds) { 

        DateTime startTime = DateTime.Now; 
        DateTime endTime = startTime.AddSeconds(seconds); 

        List<string> spinner = new List<string>(); 
    
        spinner.Add("|"); 
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|"); 

        do { 
        foreach(string item in spinner) { 
            Console.Write(item); 
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }while(DateTime.Now < endTime); 
        

    }
    // a function to show a countdown timer
    public void ShowCountDownTimer(int seconds) { 


        // ensure that the other classes of this program is working
        for(int i = seconds; i!=-1; i--) { 
            Console.Write(i); 
            Thread.Sleep(1000); 
            Console.Write("\b \b"); 
        }
        
    }
}