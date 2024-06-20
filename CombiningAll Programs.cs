using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Grade Calculator");
                Console.WriteLine("2. Ticket Price Calculator");
                Console.WriteLine("3. Triangle Type Identifier");
                Console.WriteLine("4. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GradeCalculator();
                        break;
                    case 2:
                        TicketPriceCalculator();
                        break;
                    case 3:
                        TriangleTypeIdentifier();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void GradeCalculator()
        {
            Console.WriteLine("Enter a numerical grade between 0 and 100:");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");
            }
        }

        static void TicketPriceCalculator()
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;

            Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
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
