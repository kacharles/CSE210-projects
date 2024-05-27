public class Circle:Shape { 
    private double _radius;  

    public Circle(double radius) { 
        _radius = radius; 
        _name = "Circle";
    }

    public override double GetArea() { 
        double area = Math.PI * Math.Pow(_radius, 2); 
        return area;
    }


    
}