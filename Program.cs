using System;

namespace CalculatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculatron 3000!");
            Console.WriteLine("1) Add two numbers");
            Console.WriteLine("2) Subtract two numbers");
            Console.WriteLine("3) Multiply two numbers");
            Console.WriteLine("4) Divide two numbers");
            Console.WriteLine("0) Exit");
            Console.WriteLine();

            int selection = int.Parse(Console.ReadLine());

            if (selection != 0)
            {
                Console.WriteLine();
                Console.Write("Please enter the first number: _ ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.Write("Please enter the second number: _ ");
                int secondNumber = int.Parse(Console.ReadLine());
                Console.WriteLine();
                
                if (selection == 1)
                {
                    Console.WriteLine($"The result of adding {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
                    
                } else if (selection == 2)
                {
                    Console.WriteLine($"The result of subtracting {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");
                    
                } else if (selection == 3)
                {
                    Console.WriteLine($"The result of multiplying {firstNumber} and {secondNumber} is {firstNumber * secondNumber}");
                    
                } else if (selection == 4)
                {
                    Console.WriteLine($"The result of dividing {firstNumber} and {secondNumber} is {firstNumber / secondNumber}");
                    
                }
                
                
            }


        }
    }
}
