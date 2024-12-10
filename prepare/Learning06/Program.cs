using System;

class Program
{
    static void Main(string[] args)
    {
        Square theSquare = new Square("Red", 10);
        Console.WriteLine($"Square Color is {theSquare.GetShapeColor()} and Area is {theSquare.GetArea()}");

        Circle theCircle = new Circle("Green", 5);
        Console.WriteLine($"Circle Color is {theCircle.GetShapeColor()} and Area is {theCircle.GetArea()}");

        Rectangle theRectangle = new Rectangle("Blue", 10, 5);
        Console.WriteLine($"Rectangle Color is {theRectangle.GetShapeColor()} and Area is {theRectangle.GetArea()}");


        List<Shape> shapes = new List<Shape>();
        shapes.Add(theSquare);
        shapes.Add(theCircle);
        shapes.Add(theRectangle);

        Console.WriteLine("\nShapes in the List:");
        foreach (Shape shape in shapes) {
            Console.WriteLine($"Shape Color is {shape.GetShapeColor()} and Area is {shape.GetArea()}");
        }
    }
}