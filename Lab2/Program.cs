using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("********Basic Calculator********\n");

            Console.Write("Please enter the first number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nSelect from the options:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            Console.Write(">> ");
            String option = Console.ReadLine();

            switch (option) {
                case "1":
                    Console.WriteLine("Result: " + (firstNumber + secondNumber));
                    break;
                case "2":
                    Console.WriteLine("Result: " + (firstNumber - secondNumber));
                    break;
                case "3":
                    Console.WriteLine("Result: " + (firstNumber * secondNumber));
                    break;
                case "4":
                    try
                    {
                        Console.WriteLine("Result: " + (firstNumber / secondNumber));
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: " + e.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            Console.ReadKey();
        }
    }
}

