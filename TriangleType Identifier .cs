using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleTypeIdentifier();
        }

        static void TriangleTypeIdentifier()
        {
            Console.WriteLine("Enter the lengths of the three sides of the triangle:");
            Console.Write("Side 1: ");
            int side1 = int.Parse(Console.ReadLine());

            Console.Write("Side 2: ");
            int side2 = int.Parse(Console.ReadLine());

            Console.Write("Side 3: ");
            int side3 = int.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("The triangle is Equilateral.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("The triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("The triangle is Scalene.");
            }
        }
    }
}
