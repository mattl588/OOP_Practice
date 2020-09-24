using System;

namespace C_sharp_OOP_3
{
    class Program
    {
        static void Main(string[] args) //known as a method. 
        {
            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea ("rectangle", 5, 6));
        }
    }
    public static class ShapeMath //static class. Inside must be constant or static method (function)
    {
        public static double GetArea (string shape = "", double length1 = 0, double length2 = 0) //takes str, number, number.
        {
            if (string.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }
            else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase)) //some sort of library item allowing strings to be compared. String.Equals. 
            {
                return length1 * (length2 / 2);
            }
            else if (String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.14159 * Math.Pow(length1, 2);
            }
            else
            {
                return -1;
            }
            }
        }
    }
