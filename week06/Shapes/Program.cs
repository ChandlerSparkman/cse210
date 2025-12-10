using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        
        Square square = new Square(3, "green");
        shapes.Add(square);

        Rectangle rectangle = new Rectangle(4, 3, "blue");
        shapes.Add(rectangle);

        Circle circle = new Circle(2.5, "red");
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"Color: {color}\nArea: {area}\n");
        }
    }
}