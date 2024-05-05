using System; 
using System.Collections.Generic; 
public class PromptGenerator { 

  public static List<string> _prompts = new List<string>() { 
    "What is the most important you would like to do?",
    "What are five things you would like to do today?",
    "What did you accomplish today?",
    "What do you think your life will be like when you are 30 years old?", 
    "How did you see the hand of the Lord in your life today?", 
    "What was the most memorable thing you did today?", 
  }; 

  public static Random random = new Random(); 
  
  public string DisplayPrompt() { 
      int _randomIndex = random.Next(0, _prompts.Count); 
      string _randomPrompt = _prompts[_randomIndex];
      return _randomPrompt; 
  }
}