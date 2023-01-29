using System;

public class Rectangle : Shape
{
    private double _lenght;
    private double _width;

    public Rectangle(double lenght, double width, string color,string shape): base(color, shape)
    {
        _lenght = lenght;
        _width = width;
    }
    public override double GetArea()
    {
        return _lenght * _width;
    }
}