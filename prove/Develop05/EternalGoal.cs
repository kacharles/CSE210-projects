using System.Linq.Expressions;

public class EternalGoal:Goal { 

    //EternalGoal Constructor to initialize the member variables
    public EternalGoal(string name, string description, int points):base(name, description, points) { 
        _shortName = name; 
        _description = description; 
        _points = points; 
        _goalName = "EternalGoal"; 
    }
    //A getter to get the type of goal
     public override string GetGoalName() { 
        return _goalName; 
    }

    //A getter to get the shortName of the goal
    public override string GetShortName()
    {
        return _shortName; 
    }

    //RecordEvent method to track when the user completes a an Eternal Goal
    //And receives a point for that. 

    public override int RecordEvent()
    {
        return 0; 
    }

    // A boolean method to check if the Eternal goal is completed. But this 
    //type of goal really never gets completed.

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    //Get the details string from the EternalGoal class to save it to a file;
    public override string GetDetailsString()
    {
        string GetDetailsString = $"{_goalName}:,{_shortName},{_description},{_points}"; 
        return GetDetailsString;
    }

    //A method to format the string of the EternalGoal class.
    public override string GetStringRepresentation()
    {
        return $"[] {_shortName} ({_description})";

    }


}