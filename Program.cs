using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static string[] operations = { "+", "-", "*", "/" };

        static void Main(string[] args)
        {
            double result = 0;

            //Read and check correct of first operand
            double x = ReadNumber("Enter first operand X: ");
            //Read and check correct of second operand
            double y = ReadNumber("Enter second operand Y: ");
            //Read operation
            string operation = ReadOperation("Enter operation what you need(+, -, *, /): ");

            if (operation == "/" && y == .0)
                Console.WriteLine("Oops something went wrong! No one can divide by zero.");

            switch (operation)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
            }
            Console.WriteLine(result);


        }

        private static double ReadNumber(string outputText)
        {
            double temp;
            Console.WriteLine(outputText);
            //Work until the user enters a number
            while (!double.TryParse(Console.ReadLine(), out temp))
            {
                Console.WriteLine("You must use one of the defined operations! Try again.");
            }
            return temp;
        }

        private static string ReadOperation(string outputText)
        {
            string temp;
            Console.WriteLine(outputText);
            //Work until the user enters a number
            while (!IsValidOperation(temp = Console.ReadLine()))
            {
                Console.WriteLine("Operand must only be a number! Try again.");
            }
            return temp;
        }

        static bool IsValidOperation(string operation)
        {
            return operations.Contains(operation);
        }
    }
}
