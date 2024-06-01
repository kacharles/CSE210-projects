public class Video { 

    private string _title; 
    private string _author; 
    private int _length; 

    private int _totalComment; 


    private List<Comment> _comments; 

    public Video(string title, string author, int length, List<Comment> comment) {
        _title = title; 
        _author = author; 
        _length = length; 
        _comments = comment; 
        _totalComment = GetComments();
    }

    public string GetTitle() { 
        return _title;
    }
    public string GetAuthor() { 
        return _author;
    }
    public int GetLength() { 
        return _length;
    }

    public int GetComments() { 
        int totalComment = _comments.Count(); 
        return totalComment; 
    }

    

    public void DisplayVideoInfo() { 
        Console.WriteLine($"Video Info:\nTitle:{_title} - Author:{_author} - Length:{_length} - Total Comments:{_totalComment}");
        
        Console.WriteLine($"All comments for the video {_title}");
        foreach(Comment comment in _comments) { 
                Console.WriteLine(comment.GetText());
        }

    }

}