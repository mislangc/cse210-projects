using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Console.WriteLine("");
        
        Square sqr1 = new Square(5.25,"green","square");
        Console.WriteLine(sqr1.GetArea());

        Rectangle rct1 = new Rectangle(4,7,"red","rectangle");
        Console.WriteLine(rct1.GetArea());

        Circle crcl1 = new Circle(3.5,"orange","circle");
        Console.WriteLine(crcl1.GetArea());

        Console.WriteLine("");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sqr1);
        shapes.Add(rct1);
        shapes.Add(crcl1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetShape());
            Console.WriteLine();
        }
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            string Sshape = shape.GetShape();
            string area = shape.GetArea().ToString("#.##");

            Console.WriteLine($"The area of the {color} {Sshape} is {area}.");
        }

    }
}