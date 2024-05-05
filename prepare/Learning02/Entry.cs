using System.ComponentModel.DataAnnotations;
using System.IO;

public class Entry { 
     public string _date; 
     public string _promptText; 
     public string _entryText; 


   public void Display() { 
        Console.WriteLine(GetEntry()); 
   }

   public void SetEntry(string prompt, string entryText) { 

          _date = DateTime.Now.ToString(); 
          _promptText = prompt;
          _entryText = entryText;   

   }
   
   public string GetEntry() { 
        return ($"Date: {_date} - Prompt: {_promptText}\n{_entryText}");
        // return ($"Date: {_date} - Prompt: {_promptText}\n" + "{_entryText}");
   }
}