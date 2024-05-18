using System.Drawing;
using System.Collections.Generic;
public class ReflectingActivity:Activity  {

    protected List<string> _prompt = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."

    }; 

    protected List<string> _question = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        
    }; 

    Random r;

    public ReflectingActivity() : base() { 
        _name = "Reflecting Activity"; 
        _description = "This activity will help you reflect "+
        "n times in your life when you have shown strength "+
       "and resilience. This will help you recognize the "+
       "power you have and how you can use it in other "+
       "aspects of your life.";

    }

    public void Run() { 
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        DisplayStartingMessage(); 
        Console.WriteLine("Get ready...");

        //Call the spinner method to give the user time to prepare
        ShowSpinner(5); 
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        DateTime startTime = DateTime.Now; 
        DateTime stopTime = startTime.AddSeconds(_duration);

        //The user is being prompted to carryout the breathing exercise
        do { 
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine(); 
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDownTimer(5); 
            Console.Clear(); 
            DisplayQuestions();
            ShowSpinner(5); 
            Console.WriteLine();
            DisplayQuestions();
            ShowSpinner(5);
            Console.WriteLine();
            
        }while(DateTime.Now < stopTime); 

        //The user finish the breathing activity
        Console.WriteLine("Well done!"); 
        ShowSpinner(5); 
        //The user is prompted with a congratulatory message. 
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.Clear(); 


    }

    public string GetRandomPrompt() { 
        r = new Random(); 
        int  getRandomIndex = r.Next(_prompt.Count());
        string getRandomPromt = _prompt[getRandomIndex];

        for(int i = 0; i<_prompt.Count; i++) { 

            if(getRandomPromt == _prompt[i]) { 
                _prompt.Remove(getRandomPromt);
                return getRandomPromt;
            }
        }
        return getRandomPromt;
        }

    public string GetRandomeQuestion() { 
        r = new Random(); 
        int randomQuestionIndex = r.Next(_question.Count()); 
        string getRandomQuestion = _question[randomQuestionIndex]; 
        for (int i = 0; i<_question.Count; i++) { 
            if(getRandomQuestion == _question[i]) { 
                _question.Remove(getRandomQuestion);
                return getRandomQuestion;
            }
        }
        return getRandomQuestion; 
    }

    public void DisplayPrompt() { 
        Console.WriteLine(GetRandomPrompt()); 
    }

    public void DisplayQuestions() { 
        Console.Write(GetRandomeQuestion());
    }

}