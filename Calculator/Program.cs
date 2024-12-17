using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inp1, inp2;
            string choice;
            bool done = false;

            Console.WriteLine("Welcome to Kurt's Calculator!");

            while (!done) 
            {
                Console.WriteLine("\nWhat function will you be using? Add, Divide, Subtract, Multiply (or type 'Exit' to quit):");
                choice = Console.ReadLine();

                if (choice.Equals("Exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Thank you for using Kurt's Calculator! Goodbye.");
                    done = true;
                    continue;
                }

           
                Console.Write("Enter First Number: ");
                while (!double.TryParse(Console.ReadLine(), out inp1))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                Console.Write("Enter Second Number: ");
                while (!double.TryParse(Console.ReadLine(), out inp2))
                {
                    Console.Write("Invalid input. Please enter a valid number: ");
                }

                
                switch (choice)
                {
                    case "Add":
                        Console.WriteLine($"Result: {Add(inp1, inp2)}");
                        break;
                    case "Divide":
                        if (inp2 != 0)
                        {
                            Console.WriteLine($"Result: {Divide(inp1, inp2)}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                        }
                        break;
                    case "Subtract":
                        Console.WriteLine($"Result: {Subtract(inp1, inp2)}");
                        break;
                    case "Multiply":
                        Console.WriteLine($"Result: {Multiply(inp1, inp2)}");
                        break;
                    default:
                        Console.WriteLine("Invalid function. Please enter Add, Divide, Subtract, or Multiply.");
                        break;
                }
            }
        }

        public static double Add(double inp1, double inp2)
        {
            return inp1 + inp2;
        }
        public static double Divide(double inp1, double inp2)
        {
            return inp1 / inp2;
        }
        public static double Subtract(double inp1, double inp2)
        {
            return inp1 - inp2;
        }
        public static double Multiply(double inp1, double inp2)
        {
            return inp1 * inp2;
        }
    }
}