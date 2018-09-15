using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Program
    {
        #region 1
        static Shape inputUserDataShape()
        {
            Console.WriteLine("Choose shape: square/circle (s/c)");
            string chooseShape = Console.ReadLine();
            string name;
            double value;
            if (chooseShape.ToLower() == "circle" || chooseShape.ToLower() == "c")
            {
                Console.Write("Enter circle name:");
                name = Console.ReadLine();
                Console.Write("Enter circle radius:");
                value = Convert.ToDouble(Console.ReadLine());
                return new Circle(name, value);
            }
            else if (chooseShape.ToLower() == "square" || chooseShape.ToLower() == "s")
            {
                Console.Write("Enter square name:");
                name = Console.ReadLine();
                Console.Write("Enter square side:");
                value = Convert.ToDouble(Console.ReadLine());
                return new Square(name, value);
            }
            else
            {
                throw new Exception("Your choice is not correct.");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            //Create & fill list (take look at #1 region)
            List<Shape> shapesList = new List<Shape>(10);
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    shapesList.Add(inputUserDataShape());
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error occurred: {ex.Message}\n");
                    i--;
                }
            }
            //Write name, area and perimeter of all shapes
            Console.Clear();
            Console.WriteLine("Information about all your shapes:\n");
            foreach(var shape in shapesList)
            {
                Console.WriteLine(shape.ToString());
            }
            Console.WriteLine("\nPress any key to display the name of the shape with the largest perimeter ...");
            Console.ReadKey();
            //Find shape with the largest perimeter
            Console.Clear();
            double maxPerimeter = 0;
            Shape shapeName = new Circle("null", 0);
            foreach (Shape shape in shapesList)
            {
                if (shape.Perimeter() > maxPerimeter)
                {
                    maxPerimeter = shape.Perimeter();
                    shapeName = shape;
                }
            }
            Console.WriteLine($"Shape with the name: {shapeName.Name} has the largest perimeter: {shapeName.Perimeter()}." +
                $"\n\nPress any key to display the list of shapes sorted by area ...");            
            Console.ReadKey();
            //Sort shapes by area (take a look at start of class Shape)
            Console.Clear();
            shapesList.Sort();
            Console.WriteLine("List of shapes sorted by area:\n");
            foreach (var shape in shapesList)
                Console.WriteLine(shape);
            Console.WriteLine("\nPress any key to exit ...");
            Console.ReadKey();
        }
    }
}
