using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LommeRegner
{
    class Calculator
    {

        private double _a;
        private double _b;
        private string _userOperator;
        private bool isNumber1 = false;
        private bool isNumber2 = false;
        private bool isNumber3 = false;


        public Calculator()
        {
            introduction();
            userInput();
        }

        public void introduction()
        {
            Console.WriteLine("Welcome to superAwesomeCalculator4000\n");
            Console.WriteLine("Commands that are always available: Exit (Closes the program) | Reset (Resets the program)");
            Console.WriteLine("Made by Michael and Filip\n");
        }

        public void userInput()
        {
           

            while(isNumber1 == false)
            {
                Console.Write("\n Enter first number: ");
                string input1 = Console.ReadLine();

                if (string.Equals(input1, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    exitProgram();
                }
                else if (string.Equals(input1, "reset", StringComparison.OrdinalIgnoreCase))
                {
                    resetProgram();
                }
                else
                {
                    isNumber1 = double.TryParse(input1, out _a);
                }
            }

            while (isNumber2 == false)
            {
                Console.Write("\n Enter operator: ");
                string input2 = Console.ReadLine();
                if (string.Equals(input2, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    exitProgram();
                }
                else if (string.Equals(input2, "reset", StringComparison.OrdinalIgnoreCase))
                {
                    resetProgram();
                }
                else
                {
                    if (input2.Equals("+") || input2.Equals("-") || input2.Equals("*") || input2.Equals("/"))
                    {
                        _userOperator = input2;
                        isNumber2 = true;
                    }
                    else
                    {
                        Console.Write("\n Enter one of the following operators: + | - | * | /");
                        
                    }
                }
            }

            while (isNumber3 == false)
            {
                Console.Write("\n Enter second number: ");
                string input3 = Console.ReadLine();
                if (string.Equals(input3, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    exitProgram();
                }
                else if (string.Equals(input3, "reset", StringComparison.OrdinalIgnoreCase))
                {
                    resetProgram();
                }
                else
                {
                    isNumber3 = double.TryParse(input3, out _b);
                }

             }

            result();
        }

        public void resetProgram()
        {
            _userOperator = null;
            isNumber1 = false;
            isNumber2 = false;
            isNumber3 = false;
            userInput();

        }
        public void exitProgram()
        {
            Environment.Exit(0);
        }

        public void result()
        {
            switch(_userOperator)
            {
                case "+":
                    Console.WriteLine($"\n Result: {_a + _b}\n");
                    resetProgram();
                    break;
                case "-":
                    Console.WriteLine($"\n Result: {_a - _b}\n");
                    resetProgram();
                    break;
                case "*":
                    Console.WriteLine($"\n Result: {_a * _b}\n");
                    resetProgram();
                    break;
                case "/":
                    Console.WriteLine($"\n Result: {_a / _b}\n");
                    resetProgram();
                    break;
            }
        }

    }
}
