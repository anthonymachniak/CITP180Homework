using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Author: Anthony Machniak
 * Project Name: Chapter 3 - Exercise 3
 * Start Date: 2/1/18
 * Description: Input height and width of a rectangle. Output perimeter and area.
 */

 namespace Exercise3
{
    public class Program
    {
        public static void Main()
        {
            double width, height, area, perimeter;

            DisplayInstructions();
            width = GetDimension("width");
            height = GetDimension("height");
            Console.WriteLine();

            area = CalculateArea(height, width);
            perimeter = CalculatePerimeter(height, width);

            Console.WriteLine("{0, -35} {1:f1} square feet", "The area of the rectangle is: ", area);
            Console.WriteLine("{0, -35} {1:f1} feet", "The perimeter of the rectangle is: ", perimeter);
            Console.ReadKey();
        }

        public static void DisplayInstructions()
        {
            Console.WriteLine("This program will calculate the area and perimeter of a rectangle based on your dimensions.");
            Console.WriteLine("For each dimension, you will be asked to enter the number of feet, then the number of inches for that given dimension.");
            Console.WriteLine();
        }

        public static double GetDimension(string side)
        {
            string inputValueFeet, inputValueInches;
            int feet, inches;

            Console.Write("Enter the number of feet for the rectangle's {0}: ", side);
            inputValueFeet = Console.ReadLine();
            feet = int.Parse(inputValueFeet);

            Console.Write("Enter the number of inches for the rectangle's {0}: ", side);
            inputValueInches = Console.ReadLine();
            inches = int.Parse(inputValueInches);

            return (feet + (double)inches / 12);
        }

        public static double CalculatePerimeter(double height, double width)
        {
            double perimeter;
            perimeter = height * 2 + width * 2;
            return perimeter;
        }

        public static double CalculateArea(double height, double width)
        {
            double area;
            area = height * width;
            return area;
        }
        
    }
}
