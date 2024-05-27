public class ChecklistGoal : Goal { 

    //Checklist member variables

    //_amountCompleted stores the number of times the user completes a goal
    private int _amountCompleted; 
    
    //_target the number of times a user has complete a particular goal
    private int _target; 


    //_the bonus earned for completing a particular goal
    private int _bonus; 

    //ChecklistGoal Contructor to initialize the member variables of the member variables           
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points) { 
           
            _shortName = name; 
            _description = description; 
            _points =  points; 
            _target = target; 
            _bonus = bonus; 
            _goalName = "ChecklistGoal";
    }

    // A getter name to get the type of the goal
     public override string GetGoalName() { 
        return _goalName; 
    }
    // A getter to get the shortName of the goal
    public override string GetShortName()
    {
        return _shortName; 
    }
    // RecordEvent method track the when the user completes a goal 
    // and rewards a points
    public override int RecordEvent()
    {
        return 0; 
    }

    //Is complete method checks if the user has reach their target
    //If the target is completed, the IsCompleted method returns 
    //true, else the method returns false

    public override bool IsComplete()
    {
        return false; 
    }

    //GetDetailsString methods get the details of the checklist goals and 
    //save it to a file. 
    public override string GetDetailsString()
    {
        string DetailsString = $"{_goalName}:,{_shortName},{_description},{_points}";
        return DetailsString;
    }

    //GetStringRepresentation method formats the checklist goal
    public override string GetStringRepresentation()
    {
        return $"{_shortName} ({_description}) - currently completed 0/{_target}";
    }

}


