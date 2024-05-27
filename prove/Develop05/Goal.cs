using System.ComponentModel;

public abstract class Goal { 

    //_shortName stores the name of the goal
    protected string _shortName; 
    //_description stores description of the goal
    protected string _description; 
    //_points stores the points to be earned for the goal
    protected int _points; 

    //stores the name of the type of goal
    protected string _goalName; 

    // A constructor to initialize the base class member variables
    public Goal(string name, string description, int points) { 
        _shortName = name; 
        _description = description; 
        _points = points; 
    }
    // Another Constructor
    public Goal(string GetDetailString) { 

    }
    // Abtract method RecordEvent
    public abstract int RecordEvent(); 

    // Abstract method IsComplete
    public abstract bool IsComplete(); 

    // Abstract method GetDetailsString
    public abstract string GetDetailsString(); 

    // Abstract method GetStringRepresentation
    public abstract string GetStringRepresentation(); 

    //Create an abstract Getter for the goal name; 
    public abstract string GetGoalName();

    //Abstract GetShortName;
    public abstract string GetShortName(); 
}
   