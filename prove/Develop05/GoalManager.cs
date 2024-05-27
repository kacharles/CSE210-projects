using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


public class GoalManager { 

List<Goal> _goals;
private int _score; 

private int _temp; 

private string _completed;

private string _fileName; 

int option; 

public GoalManager() { 
_goals = new List<Goal>(); 
_score = 0; 
_temp = 0; 
_completed = ""; 
}

public void Start() { 
    DisplayPlayerInfo();
    do{
        Console.WriteLine("Menu Options: "); 
        Console.WriteLine(" 1. Create New Goal"); 
        Console.WriteLine(" 2. List Goals"); 
        Console.WriteLine(" 3. Save Goals"); 
        Console.WriteLine(" 4. Load Goals"); 
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");  
        Console.Write("Select a choice from the menu: ");
        option = int.Parse(Console.ReadLine());

        if(option == 1) { 
            Console.WriteLine("Create New Goals\n"); 
            CreateGoal(); 
            Console.Clear(); 
        }
        else if (option == 2) { 
            Console.WriteLine("List Goal Details\n");
            ListGoalDetails(); 
        }
        else if (option == 3) { 
            Console.WriteLine("Save Goals\n"); 
            SaveGoal();
            Console.Clear();
        }

        else if(option == 4) { 
            Console.WriteLine("Load Goals\n");
            LoadGoals(); 
            Console.Clear();
        }
        else if(option == 5) { 
            Console.WriteLine("Record Event"); 
            RecordEvent(); 
        }
        else { 
            Console.WriteLine("Goodbye!"); 
        }
    }while(option!=6); 

}

public void DisplayPlayerInfo() { 
    Console.WriteLine($"You have {_score} points.\n");
}

public void ListGoalNames() { 

        int i = 1; 
        foreach(Goal goals in _goals) { 
            Console.WriteLine($"{i}. {goals} - {goals.GetShortName()}");
            i++; 
        }
        
    }


public void ListGoalDetails() { 
    
    foreach(Goal g in _goals) { 
        Console.WriteLine($"{g.GetGoalName()} - {g.GetStringRepresentation()}"); 
    }
}

public void CreateGoal()  {
    //A varaible to store the user option either to create a particulra goal;
    Console.WriteLine(); ;
    // int ctrlOption; 
    Console.WriteLine("Enter number 1 - 3 to select a goal: "); 
    Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\n"); 
    Console.Write("Which type of goal would you like to create: "); 
    option = int.Parse(Console.ReadLine()); 

    if (option == 1) { 
        string name, description; 
        int point; 
        Console.Write("What is the name of your goal: "); 
        name = Console.ReadLine(); 
        Console.Write("What is a short description of your goal: "); 
        description = Console.ReadLine(); 
        Console.Write("What much points you would like to earn for this goal: "); 
        point = int.Parse(Console.ReadLine()); 
        SimpleGoal sg = new SimpleGoal(name, description, point);
        _goals.Add(sg); 
    }
    if (option == 2) { 
        string name, description; 
        int point; 
        Console.Write("What is the name of your goal: "); 
        name = Console.ReadLine(); 
        Console.Write("What is a short description of your goal: "); 
        description = Console.ReadLine(); 
        Console.Write("What much points you would like to earn for this goal: "); 
        point = int.Parse(Console.ReadLine()); 
        EternalGoal eg = new EternalGoal(name, description, point);
        _goals.Add(eg);

    }
    if (option == 3) { 
        string name, description; 
        int point; 
        int  target =0; 
        int bonus = 0;
        Console.Write("What is the name of your goal: "); 
        name = Console.ReadLine(); 
        Console.Write("What is a short description of your goal: "); 
        description = Console.ReadLine(); 
        Console.Write("What much points you would like to earn for this goal: "); 
        point = int.Parse(Console.ReadLine()); 
        Console.Write("How many times would you like to repeat this this? ");
        target = int.Parse(Console.ReadLine()); 
        Console.Write("What much bonus would you like to earn for completing this goal: ");
        bonus = int.Parse(Console.ReadLine()); 
        ChecklistGoal cg = new ChecklistGoal(name, description, point, target, bonus);
        _goals.Add(cg);
    }
}



public void RecordEvent() {
    ListGoalNames(); 
}

public void SaveGoal() { 

    Console.Write("Enter a file name to save the goal: "); 
    _fileName = Console.ReadLine(); 

    using(StreamWriter sw = new StreamWriter(_fileName)) { 
        foreach(Goal goal in _goals) { 

            sw.Write($"{_score}\n{goal.GetDetailsString()}"); 
        }
    }

}

public void LoadGoals() { 
    Console.Write("Enter the name of the file you would like to load"); 
    _fileName = Console.ReadLine(); 
    string[] _data = System.IO.File.ReadAllLines(_fileName); 
    foreach(string data in _data) { 
        string[] parts = data.Split(","); 
        string goalName = parts[0];
        string shortName = parts[1]; 
        string description = parts[2]; 
        int points = int.Parse(parts[3]);
        // int target = int.Parse(parts[4]); 
        // int bonus = int.Parse(parts[5]); 

        if(goalName == "SimpleGoal:") {
        SimpleGoal sg = new SimpleGoal(shortName, description, points);
        _goals.Add(sg); 

        }
        else if (goalName == "EternalGoal:") {
        EternalGoal et = new EternalGoal(shortName, description, points); 
        _goals.Add(et);
        }
        // else if (goalName == "ChecklistGoal:") { 
        //     ChecklistGoal clg = new ChecklistGoal(shortName, description, points, target, bonus);
        //     _goals.Add(clg); 
        // }
    }
    Console.WriteLine($"Your goals have been loaded from the file {_fileName}");

}
}
