using System;

class Program
{
    static void Main(string[] args)

    {

        string title1 = "Video One"; 
        string author1 =  "Author One"; 
        int length1 = 7200; 
        string person1 = "Person1"; 
        string text1 = "some text 1";
        string person2 = "Person2";
        string text2 = "Some text 2";
        string person3 = "Person3";
        string text3 = "Some text 3"; 
        Comment comment1 = new Comment(person1, text1); 
        Comment comment2 = new Comment(person2, text2);
        Comment comment3 = new Comment(person3, text3); 
        List<Comment> _comments1 = new List<Comment>(); 
        _comments1.Add(comment1); 
        _comments1.Add(comment2); 
        _comments1.Add(comment3); 
        Video videoOne = new Video(title1, author1, length1, _comments1);

        //__________________________________________________________________

        string title2 = "Video Two"; 
        string author2 =  "Author Two"; 
        int length2 = 8200; 
        string person4 = "Person4"; 
        string text4 = "some text 4";
        string person5 = "Person5";
        string text5 = "Some text 5";
        string person6 = "Person6";
        string text6 = "Some text 6"; 
        Comment comment4 = new Comment(person4, text4); 
        Comment comment5 = new Comment(person5, text5);
        Comment comment6 = new Comment(person6, text6); 
        List<Comment> _comments2 = new List<Comment>(); 
        _comments2.Add(comment4); 
        _comments2.Add(comment5); 
        _comments2.Add(comment6); 
        Video videoTwo = new Video(title2, author2, length2, _comments2);

        //___________________________________________________________________

        string title3 = "Video Three"; 
        string author3 =  "Author Three"; 
        int length3 = 9200; 
        string person7 = "Person7"; 
        string text7 = "some text 7";
        string person8 = "Person8";
        string text8 = "Some text 8";
        string person9 = "Person9";
        string text9 = "Some text 9"; 
        Comment comment7 = new Comment(person7, text7); 
        Comment comment8 = new Comment(person8, text8);
        Comment comment9 = new Comment(person9, text9); 
        List<Comment> _comments3 = new List<Comment>(); 
        _comments3.Add(comment7); 
        _comments3.Add(comment8); 
        _comments3.Add(comment9); 
        Video videoThree = new Video(title3, author3, length3, _comments3);

        //__________________________________________________________________
        string title4 = "Video Four"; 
        string author4 =  "Author Four"; 
        int length4 = 10200; 
        string person10 = "Person10"; 
        string text10 = "some text 10";
        string person20 = "Person20";
        string text20 = "Some text 20";
        string person30 = "Person30";
        string text30 = "Some text 30"; 
        Comment comment10 = new Comment(person10, text10); 
        Comment comment20 = new Comment(person20, text20);
        Comment comment30 = new Comment(person30, text30); 
        List<Comment> _comments4 = new List<Comment>(); 
        _comments4.Add(comment10); 
        _comments4.Add(comment20); 
        _comments4.Add(comment30); 
        Video videoFour = new Video(title4, author4, length4, _comments4);
        List<Video> _videos = new List<Video>(); 
        _videos.Add(videoOne); 
        _videos.Add(videoTwo);
        _videos.Add(videoThree);
        _videos.Add(videoFour);
        
        foreach(Video video in _videos) { 
            video.DisplayVideoInfo(); 
        }
        
    }
}