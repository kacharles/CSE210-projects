using System.Diagnostics.CodeAnalysis;
using System.Formats.Tar;
using System.IO; 

public class Journal { 
    public List<Entry> _entries = new List<Entry>(); 
    
    public void AddEntry(Entry entry) { 

        // DateTime _currentDate = DateTime.Now;
        // string _formatDate = _currentDate.ToShortDateString(); 
        // entry._date = _formatDate; 
        // entry._promptText = pg.DisplayPrompt(); 
        // Console.WriteLine(entry._promptText);
        // entry._entryText = Console.ReadLine();
        // _entries.Add(entry); 
        _entries.Add(entry);
    }

    public void DisplayAll() { 

        foreach (Entry text in _entries) { 
            text.Display(); 
        }
     
    }
    

    public static void SaveToFile(List<Entry> _entries) { 
        
        Console.WriteLine("Please enter the name of the file");
        string file = Console.ReadLine();
        using(StreamWriter writeToFile = new StreamWriter(file, true)) { 

            foreach(Entry ent in _entries) { 
                writeToFile.WriteLine(ent.GetEntry());

            }

        }
    }

    public static void LoadFromFile() { 
        Console.WriteLine("Please enter the name of the file ");
        string file = Console.ReadLine(); 
        string[] _readFile = System.IO.File.ReadAllLines(file); 
        foreach (string line in _readFile) {    
           Console.WriteLine(line); 
        }
        
    }

}