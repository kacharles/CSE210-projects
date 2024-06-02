using System.Reflection.Metadata.Ecma335;

public class Order { 

    private List<Product> _products;
    private Customer _customer; 

    private string _shippingLBL;
    private int _totalCost; 
    private int _shippingCost; 
    public Order(List<Product> product, Customer customer) { 
        _products = product; 
        _customer = customer; 
    
    }

    public void ComputeOrder() { 
        foreach(Product p in _products) { 
            Console.WriteLine($"${p.GetPrice()} * {p.GetQuantity()} = ${p.computeCost()}");
            Console.WriteLine();
           _totalCost += p.computeCost(); 
           //Console.WriteLine($"Total Cost: ${_totalCost} + {ShippmentCost()}");
        }
        Console.WriteLine($"Total Cost:${_totalCost} + Shippment: ${ShippmentCost()}");
    }
    public int ShippmentCost() { 
            
            if(_customer.IsAddressAmerica() == true) { 
                _shippingCost = 5; 
            }
            else if(_customer.IsAddressAmerica() == false) { 
                _shippingCost = 35; 
            }
        

        return _shippingCost;
        
    }

    public void GetPackLBL() { 
        foreach(Product product in _products) { 
             Console.WriteLine(product.PackLBL());
        }
        
    }

    public string GetShippingLBL() { 
    
        _shippingLBL = ($"{_customer.GetCustomerAddress()}");
    
        return _shippingLBL;
    }

    //Return today and complete this assignment.
}