using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk6Ex2
{
    internal class Program
    {
        class Shape
        {
            // Inner class for Circle
            public class Circle
            {
                public double Radius { get; set; } // collects the radius of the circle
                public Circle(double radius) // constructor for the circle
                {
                    Radius = radius;
                }
                public double CalculateArea() // method to calculate the area of the circle
                {
                    // calculate and display the area of the circle
                    Console.WriteLine("Area of the circle is: " + Math.PI * Radius * Radius);
                    return Math.PI * Radius * Radius;
                }
            }

            // class for Rectangle
            public class Rectangle 
            {
                //collects the length and width of the rectangle
                public double Length { get; set; }
                public double Width { get; set; }
                public Rectangle(double length, double width) // constructor for the rectangle
                {
                    Length = length;
                    Width = width;
                }
                public double CalculateArea() // method to calculate the area of the rectangle
                {
                    // calculate and display the area of the rectangle
                    Console.WriteLine("Area of the rectangle is: " + Length * Width);
                    return Length * Width;
                }
            }

            // class for Triangle
            public class Triangle
            {
                //collects the base and height of the triangle
                public double Base { get; set; }
                public double Height { get; set; }
                public Triangle(double baseLength, double height) // constructor for the triangle
                {
                    Base = baseLength;
                    Height = height;
                }
                public double CalculateArea() // method to calculate the area of the triangle
                {
                    // calculate and display the area of the triangle
                    Console.WriteLine("Area of the triangle is: " + 0.5 * Base * Height);
                    return 0.5 * Base * Height;
                }
            }
        }

        static void Main(string[] args)
        {
            List<object> shapes = new List<object>(); // list to store the shapes

            while (true) // loop to keep the program running
            {
                // menu to choose the shape
                Console.WriteLine("Choose a shape to create:");
                Console.WriteLine("1. Circle");
                Console.WriteLine("2. Rectangle");
                Console.WriteLine("3. Triangle");
                Console.WriteLine("4. Display all areas");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter radius of the circle: ");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        shapes.Add(new Shape.Circle(radius));
                        Console.WriteLine("Circle added! \n");
                        break;

                    case "2":
                        Console.Write("Enter length of the rectangle: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter width of the rectangle: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        shapes.Add(new Shape.Rectangle(length, width));
                        Console.WriteLine("Rectangle added! \n");
                        break;

                    case "3":
                        Console.Write("Enter base of the triangle: ");
                        double baseLength = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter height of the triangle: ");
                        double height = Convert.ToDouble(Console.ReadLine());
                        shapes.Add(new Shape.Triangle(baseLength, height));
                        Console.WriteLine("Triangle added! \n");
                        break;

                    case "4":
                        Console.WriteLine("\nShape Areas:");
                        foreach (var shape in shapes)
                        {
                            if (shape is Shape.Circle circle)
                                Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
                            else if (shape is Shape.Rectangle rectangle)
                                Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
                            else if (shape is Shape.Triangle triangle)
                                Console.WriteLine($"Triangle Area: {triangle.CalculateArea()}");
                        }
                        break;

                    case "5":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        Console.WriteLine("Please try again.");
                        break;
                }
            }
        }
    }
}
