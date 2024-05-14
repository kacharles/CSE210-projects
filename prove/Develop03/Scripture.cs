public class Scripture { 
    // Member variables
    Reference _reference; 

    string _text; 
    List<Word> _words = new List<Word>(); 

    // Scripture constructor to initialize the _reference variable
    // List of words
    public Scripture(Reference reference, string text) { 
        _reference = reference; 
        _text = text; 
        // the purpose of the text variable in Scripture 
        // constructor is update the World list
        String[] newText = text.Split(" "); 
        foreach(string nword in newText) { 
        Word w = new Word(nword); 
        _words.Add(new Word(w.GetDisplay()));

        }
        

    }
    // A function that hide random words in the List of words
    public void HideRandomWords(int numberToHide) {

        // while (numberToHide + 1 >= 0) {
        //    generate a random number
        Random random = new Random();
        int getRandom = random.Next(0, _words.Count());

        Word hidden = _words[getRandom];
        hidden.Hide();
        _words[getRandom] = new Word(hidden.GetDisplay());
        //  numberToHide--; 
      
    // }
        }
        
    
    // Return a scripture reference
    // And a list of words
    public string GetDisplayText() {
        List<string> newVerse = new List<string>();
        for (int i = 0; i < _words.Count(); i++)
        {
            newVerse.Add(_words[i].GetDisplay());
        }
        string finalForm = String.Join(" ", newVerse);
            return _reference.GetDisplayText() + " " + finalForm;
    }

    public bool IsCompletelyHidden() { 
        return false;
    }
}