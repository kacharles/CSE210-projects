public class Shape { 
    private string _color; 
    protected string _name; 

    public string GetColor() { 
        return _color;
    }

    public void SetColor(string color) { 
        _color = color; 
    }

    public virtual double GetArea() { 
        Console.WriteLine($"{_name}\n"); 
        return 0; 
    }
}