public class Lectures:Event { 

    private int _capacity; 
    private int _duration;
    private string _lecturer; 
    private string _theme; 
    private string _purpose; 

    public Lectures(string eventTitle, string description, DateTime date, Address address, int capacity, int duration, string lecturer, string theme, string purpose):base(eventTitle, description, date, address) { 
       
        _eventTitle = eventTitle; 
        _description = description; 
        _date = date;
        _address = address;
        _capacity = capacity; 
        _duration = duration; 
        _theme = theme; 
        _lecturer = lecturer; 
        _theme = theme; 
        _purpose = purpose; 

    }

    public void DisplayEventDetails() { 
        Console.WriteLine("----------Event Information----------");
        DisplayEventInfo(); 
        Console.WriteLine("--------------------------------------");
        Console.WriteLine($"Speaker: {_lecturer}.");
        Console.WriteLine($"Theme: {_theme}");
        Console.WriteLine($"Duration: {_duration} minutes.");
        Console.WriteLine($"Capacity: {_capacity} people.");
        Console.WriteLine($"Purpose: {_purpose}");
        Console.WriteLine();
    }
}