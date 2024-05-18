public class WritingAssignment:Assignment { 
   
    private string _title; 

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, title) { 
        _title = title; 
    }


    public string GetWritingInfomation() { 
        string studentName = GetStudentName(); 
        return $"{_title} by {studentName}";
    }
}