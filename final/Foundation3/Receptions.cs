public class Receptions:Event { 

    private string _email; 
    public Receptions(string eventTitle, string description, DateTime date, Address address, string email):base(eventTitle, description, date, address){ 
        _eventTitle = eventTitle; 
        _description = description; 
        _date = date; 
        _address = address; 
        _email = email;
    }

    public void DisplayEventDetails() { 
        Console.WriteLine("----------Event Info----------"); 
        DisplayEventInfo(); 
        Console.WriteLine($"RSVP: {_email}");
        Console.WriteLine(); 
    }
}