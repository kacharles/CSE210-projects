public class Address { 
    private string _streetAddress; 
    private string _city; 
    private string _country; 

    public Address(string streetAddress, string city, string country) { 
        
        _country = country; 
        
        _city = city; 
        
        _streetAddress = streetAddress;
    }

    public string GetAddress() { 
        return ($"{_streetAddress}, {_city}, {_country}");
    }
}