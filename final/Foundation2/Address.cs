public class Address { 

    private string _streetAddress; 
    private string _city; 
    private string _stateProvince; 
    private string _country; 
    private bool _isAmerica; 


    public Address(string streetAddress, string city, string stateProvince, string country) { 
        _stateProvince = stateProvince; 
        _city = city; 
        _streetAddress = streetAddress; 
        _country = country; 
    }

    public string GetStreetAddress() { 
        return _streetAddress; 
    }
    public string GetCity() { 
        return _city; 
    }

    public string GetStateProvince() { 
        return _stateProvince;
    }

    public string GetCountry() { 
        return _country;
    }

    public bool IsAmerica() { 
        if(_country == "America") { 
            _isAmerica = true; 
        }
        else if(_country != "America") { 
            _isAmerica = false;
        }
        return _isAmerica; 
    }

    public string GetAddres() { 
        string address; 
        address = ($"{_streetAddress}\n{_stateProvince}\n{_city}\n{_country}");
        return address; 
    }
}