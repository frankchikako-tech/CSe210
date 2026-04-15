using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create list of shapes (POLYMORPHISM HERE)
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        // Loop through shapes
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine("----------------------");
        }
    }
}