using System.Formats.Asn1;

public class Square:Shape { 
    private double _side;

    public Square(double side) { 
        _side = side;
        _name = "Square"; 
    }

    public override double GetArea()
    {
        double area =  _side * _side;
        return area; 
        
    }
}