public class Word { 
    public string _text; 
    private bool _isHidden; 

    public Word(string text) {

        _text = text; 
        _isHidden = false; 

    }

    public void Hide() { 
        _isHidden = true; 
    }

    public void Show() { 
        _isHidden = false; 
    }

    public bool IsHidden() { 
        return _isHidden;
    }

    public string GetDisplay() { 
        
        if (IsHidden()) { 
            // char[] charArr = _text.ToArray(); 
            // for (int i = 0; i < charArr.Length; i++ ) { 

            //     if(char.IsLetter(charArr[i])) { 

            //         charArr[i] = '_'; 

            //     }
            
            // }
            // return _text = new string (charArr); 
            return new string('_', _text.Count());
        
        }
        return _text; 
    }

}