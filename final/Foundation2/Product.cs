using System.Runtime.InteropServices;

public class Product { 

    private string _name;
    private int _productID; 
    private int _price;
    private int _quantity; 

    public Product(string name, int productID, int price, int quantity) { 
        _name = name; 
        _productID = productID; 
        _price = price; 
        _quantity = quantity; 
    }

    public string GetName() { 
        return _name; 
    }
    public int GetPrice() { 
        return _price; 
    }
    public int GetProductID() { 
        return _productID; 
    }
    public int GetQuantity() { 
        return _quantity; 
    }

    public int computeCost() { 
        int totalCost = _price * _quantity;
        return totalCost; 
    }

    public string PackLBL() { 
        return ($"Product Name:{_name} - Product ID:{_productID}");
    }
}