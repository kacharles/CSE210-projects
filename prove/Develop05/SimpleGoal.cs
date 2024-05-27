using System.IO.Enumeration;

public class SimpleGoal:Goal { 
    //A member variable to validate whether or not a Simple Goal type has been 
    //Completed

    private bool _isComplete; 

    //A constructor to initialize the SimpleGoal class
    public SimpleGoal(string name, string description, int points): base(name, description, points) { 
        _shortName = name; 
        _description = description; 
        _points = points; 
        _goalName = "SimpleGoal";
        _isComplete = false;
    }

    //Another constructor, but it's not actuallly in used
    public SimpleGoal(string GetDetailString):base(GetDetailString) { 

    }

    //A setter to set the state of the isComplete variable
    public void SetIsComplete(bool isComplete) { 
        _isComplete = isComplete;
    }


    //A getter to get the name of the type of goal
    public override string GetGoalName() { 
        return _goalName; 
    }

    // A getter to get the shortName of the 
    // the goal.
    public override string GetShortName()
    {
        return _shortName; 
    }

    public override int RecordEvent()
    {
        if(_isComplete == true) { 
              return _points;
        }
        else if (_isComplete == false){ 
            _points = 0; 
            return _points;
        }

        return _points; 
        
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string GetDetailsString = $"{_goalName}:,{_shortName},{_description},{_points},{_isComplete}"; 
        return GetDetailsString;
    }

    public override string GetStringRepresentation()
    {
        string isCompleted = ""; 

        if (_isComplete == true) { 
            isCompleted = "X"; 
        }
        else if(_isComplete == false) { 
            isCompleted = ""; 
        }
        return $"[{isCompleted}] {_shortName} ({_description})";
    }

}