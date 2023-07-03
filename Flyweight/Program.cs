// See https://aka.ms/new-console-template for more information

using Flyweight.Classes;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Design Pattern: Flyweight, Null object \n");
        Console.WriteLine("Red color Circles ");
        for (int i = 0; i < 3; i++)
        {
            Circle circle = (Circle)ShapeFactory.GetShape(typeof(Circle));
            circle.SetColor("Red");
            circle.Draw();
        }
        Console.WriteLine();

        Console.WriteLine("Green color Circles ");
        for (int i = 0; i < 3; i++)
        {
            Circle circle = (Circle)ShapeFactory.GetShape(typeof(Circle));
            circle.SetColor("Green");
            circle.Draw();
        }
        Console.WriteLine();

        Console.WriteLine("Green color Rectangle ");
        for (int i = 0; i < 3; ++i)
        {
            Rectangle circle = (Rectangle)ShapeFactory.GetShape(typeof(Rectangle));
            circle.SetColor("Green");
            circle.Draw();
        }
        Console.WriteLine();

        Console.WriteLine("Orange color Rectangle");
        for (int i = 0; i < 3; ++i)
        {
            Rectangle circle = (Rectangle)ShapeFactory.GetShape(typeof(Rectangle));
            circle.SetColor("Orange");
            circle.Draw();
        }
        Console.WriteLine();

        Console.WriteLine("Null Shape test: nothing should be drawn.");
        var shape = (NullShape)ShapeFactory.GetShape(typeof(Test));
        shape.Draw();
    }
    class Test { } 
}