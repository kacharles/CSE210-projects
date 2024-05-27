public class Rectangle:Shape { 
    
    private double _width; 
    private double _length; 

    public Rectangle(double width, double length) { 
        _width = width; 
        _length = length; 
        _name = "Rectangle"; 
    }

    public override double GetArea() { 
        double area = _length * _width; 
        return area; 
    }
}