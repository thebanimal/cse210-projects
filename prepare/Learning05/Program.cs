using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 2);
        Rectangle rectangle = new Rectangle("red", 3, 4);
        Circle circle = new Circle("yellow", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}