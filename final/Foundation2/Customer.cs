public class Customer { 

    private string _name;
    private Address _address; 
    private bool _isAmerica; 
    public Customer(string name, Address address)  {
        _name = name; 
        _address = address; 
    }

    public bool IsAddressAmerica() { 

        if(_address.IsAmerica() == true) {
            _isAmerica = true;
        }
        
        else { 
            _isAmerica = false;
        }

        return _isAmerica; 
    }

    public string GetCustomerAddress() { 
        return ($"Customer Name: {_name}\nAddress: {_address.GetAddres()}");
    }
}