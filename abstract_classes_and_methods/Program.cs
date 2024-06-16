// See https://aka.ms/new-console-template for more information

using System.Collections;

namespace abstract_classes_and_methods
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {circle.GetArea()}");  
            Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

        }
        

    }
}