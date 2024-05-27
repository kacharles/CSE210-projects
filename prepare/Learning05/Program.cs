using System;


class Program
{
   
    static void Main(string[] args)
   { 
    List<Shape> _allShape = new List<Shape>(); 
    Circle c = new Circle(5); 
    c.SetColor("Red"); 
    Rectangle r =  new Rectangle(5, 10); 
    r.SetColor("White"); 
    Square s = new Square(15); 
    s.SetColor("Blue"); 
    _allShape.Add(c); 
    _allShape.Add(r); 
    _allShape.Add(s);

    foreach(Shape shape in _allShape) { 
            Console.WriteLine($"{shape.GetColor()}-{shape.GetArea()}");
    }
   }

}
