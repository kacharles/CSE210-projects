public class JournalActivity:Activity { 
    public JournalActivity() { 
        _name = "Journal Activity";
        _description = "This activity will help you record your thougths" +
        " about experiences that you have in your life.";
    }

    private List<string> _journalPrompts = new List<string>() {
    "What is the most important you would like to do?",
    "What are five things you would like to do today?",
    "What did you accomplish today?",
    "What do you think your life will be like when you are 30 years old?"
    // "How did you see the hand of the Lord in your life today?", 
    // "What was the most memorable thing you did today?", 
    }; 
    private List<string> _newJournalPrompt = new List<string>();

    private List<string> _journal = new List<string>();
    Random random;
    // This method is used to get new prompts from the user
    public string GetJournalPrompts() { 
        random = new Random(); 
        int randomIndex = random.Next(_journalPrompts.Count()); 
        string randomPrompt = _journalPrompts[randomIndex];
        // int k = _journalPrompts.Count();
        // Want to use a for loop and remove random propmt from the 
        // list until the loop is empty and give it another list 
        // that will past the list item to the original list. 
        // I will try this with a while loop
        // for (int i = 0; i<_journalPrompts.Count; i++) { 

        //         _newJournalPrompt.Add(randomPrompt);
        //         _journalPrompts.RemoveAt(i);
        
        // }
        // this do...while loop will ensure that a prompt is 
        // displayed and removed from the list and get added to 
        // a new list. When the list index is not equal to zero
        // random prompt wil be displayed and removed. When the list
        // index is equal to 
        _newJournalPrompt = _journalPrompts;
       for (int i=5; i<1; i--) { 
         int k = _journalPrompts.IndexOf(randomPrompt);
            _journalPrompts.RemoveAt(k);
            if(i==0) { 
            _journalPrompts = _newJournalPrompt;
            }
       }
        return randomPrompt;
        
    }

    public void WriteToJournal() {  
        Console.Write(">");
        string entryText = Console.ReadLine();
        _journal.Add(entryText); 
        Console.Clear(); 
    }

    public void Run() { 
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.Black;

        DisplayStartingMessage(); 
        Console.Write("Get Ready..."); 
        ShowSpinner(2);
        Console.WriteLine("-- Consider the prompts and write to your journal\n");
        DateTime startTime = DateTime.Now; 
        DateTime stopTime = startTime.AddSeconds(_duration);

        do { 

            Console.WriteLine($"--{GetJournalPrompts()}--\n");
            ShowSpinner(1);
            WriteToJournal(); 

        }while (DateTime.Now < stopTime);
        Console.WriteLine($"You have written {_journal.Count()} items into your journal!\n");

        //The user finish the breathing activity
        Console.WriteLine("✔ Well done 🏁"); 
        ShowSpinner(5); 
        //The user is prompted with a congratulatory message. 
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.Clear(); 

    }
}