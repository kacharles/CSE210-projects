public class OutdoorGathering:Event { 
    private string _weatherInfo; 

    public OutdoorGathering(string eventTitle, string description, DateTime date, Address address, string weatherInfo):base(eventTitle, description, date, address) { 
        _eventTitle = eventTitle; 
        _description = description; 
        _date = date; 
        _address = address; 
        _weatherInfo = weatherInfo; 
    }

    public void DisplayEventDetails() { 
        Console.WriteLine("----------Event Information----------");
        DisplayEventInfo();
        Console.WriteLine($"Weather Statement: {_weatherInfo}");
    }
}