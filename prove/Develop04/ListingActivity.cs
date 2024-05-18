public class ListingActivity:Activity { 
    private int _count; 
    private List<string> _list = new List<string>();
    private List<string> _prompts = new List<string>() {
        "Who are people that you appreciate?",
        "What are personal strengths of yours? ",
        "Who are people that you have helped this week? ",
        "When have you felt the Holy Ghost this month? ",
        "Who are some of your personal heroes?"
    }; 

    public ListingActivity() : base() { 
        _name = "Listing Activity"; 
        _description = "This activity will help you reflect on " +
        "the good things in your life by having you list as many " +
        "things as you can in a certain area.";

    }

    public void Run() { 
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.BackgroundColor = ConsoleColor.White;
         DisplayStartingMessage(); 
        Console.WriteLine("Get ready...");

        //Call the spinner method to give the user time to prepare
        ShowSpinner(5); 
        Console.WriteLine("List as many responses you can to the following prompt \n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        DateTime startTime = DateTime.Now; 
        DateTime stopTime = startTime.AddSeconds(_duration);

        //The user is being prompted to carryout the breathing exercise
        do { 
            Console.Write("You may begin in: ");
            ShowCountDownTimer(5); 
           
            Console.WriteLine();
            while(DateTime.Now < stopTime) {
                GetListFromUser();
            }
            Console.WriteLine();

        }while(DateTime.Now < stopTime); 
        Console.WriteLine($"You have list {_list.Count()} items!\n");

        //The user finish the breathing activity
        Console.WriteLine("Well done!"); 
        ShowSpinner(5); 
        //The user is prompted with a congratulatory message. 
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.Clear(); 


    }
    public string GetRandomPrompt() { 
        Random random = new Random(); 
        int randomIndex = random.Next(_prompts.Count());
        string randomPrompt = _prompts[randomIndex]; 
        return randomPrompt; 

    }

    public List<string> GetListFromUser() { 
        Console.Write(">");
        string userInput = Console.ReadLine(); 
        _list.Add(userInput); 
        return _list; 
    }
}