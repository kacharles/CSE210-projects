using System;
public class Event { 

    protected string _eventTitle; 
    protected string _description;
    protected DateTime _date;
    protected Address _address; 

    public Event(string eventTitle, string description, DateTime date, Address address) { 
        _eventTitle = eventTitle;
        _description = description; 
        _date = date; 
        _address = address; 
    }
    public void DisplayEventInfo() { 
        Console.WriteLine($"Event Type: {_eventTitle} Event.");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date & Time: {_date}"); 
        Console.WriteLine($"Address: {_address.GetAddress()}"); 
    }
    
}