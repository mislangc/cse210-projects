using System;

public abstract class Shape
{
    private string _color;
    private string _shape;
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetShape()
    {
        return _shape;
    }
    public void SetShape(string shape)
    {
        _shape = shape;
    }
    public Shape(string color, string shape)
    {
        _color = color;
        _shape = shape;
    }
    public abstract double GetArea();
}