using System.Linq;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an console calculator\n");

            decimal num1 = GetValidNumber("Enter first number: ");
            decimal num2 = GetValidNumber("Enter second number: ");

            string action = "";
            decimal result;
            bool validAction = false;

            //Loop to check for valid action
            while (!validAction)
            {
                Console.Write("Enter an action ( +, -, *, / ):");
                action = Console.ReadLine();

                if (action.Length == 1 && "+-*/".Contains(action))
                {
                    validAction = true;
                }
                else
                {
                    Console.WriteLine("Invalid action, try again:");
                }
            }
            //Menu for calculation
            switch (action)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"The result is {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"The result is {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"The result is {result}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"The result is {result}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Can not divide by zero.");
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine("Press key to exit");
            Console.ReadKey();
        }
        //Method to check for valid input
        static decimal GetValidNumber(string message)
        {
            decimal number = 0;
            bool valid = false;

            while (!valid)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out number))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid number");
                }
            }
            return number;
        }
    }
}
