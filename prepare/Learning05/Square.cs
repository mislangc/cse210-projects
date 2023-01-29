using System;

public class Square : Shape
{
    private double _side;
    
    public Square(double side, string color, string shape): base(color, shape)
    {
        _side = side;
    }
    public override double GetArea()
    {
        return _side * _side;
    }
}