public class Reference { 
    private string _book; 
    private int _chapter;
    private int _verse; 
    private int _endVerse; 

    public Reference(string book, int chapter, int verse) { 

      _book = book; 
      _chapter = chapter; 
      _verse = verse; 

    }
    public Reference(string book, int chapter, int Startverse, int endVerse=0) { 
      _book = book; 
      _chapter = chapter; 
      _verse = Startverse;
      _endVerse = endVerse;  


    }

    public string GetDisplayText() { 
        
        string returnType1 = $"{_book} {_chapter}:{_verse}";
        string returnType2 = $"{_book} {_chapter}:{_verse} - {_endVerse}";
        
        if (_endVerse == 0) { 
          return returnType1;
        }
        else { 
          return returnType2; 
        }

        }

          }

