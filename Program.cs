using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaration 
            int firstNumber = 0;
            int secondNumber = 0;
            int choice = 0;

            //Title for the calculator
            Console.WriteLine("CALCULATOR APPLICATION");

            //asking the user to input their first number
            Console.WriteLine("What is the first number?");
            //user inputs their first number in
            firstNumber = Convert.ToInt32(Console.ReadLine());

            //asking the user to input their second number
            Console.WriteLine("What is the second number?");
            //user inputs their second number in
            secondNumber = Convert.ToInt32(Console.ReadLine());

            //asking the user to pick 1 out of 4 different math calculations to pick
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("Enter your choice (1-4): ");

            //user inputs their choice of math calculation
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                //this input shows a result of addition
                case 1:
                    Console.WriteLine($"The result of Addition is: {firstNumber + secondNumber}");
                    break;
                //this input shows a result of subtraction
                case 2:
                    Console.WriteLine($"The result of Subtraction is: {secondNumber - firstNumber}");
                    break;
                //this input shows a result of multiplication
                case 3:
                    Console.WriteLine($"The result of Multiplication is: {secondNumber * firstNumber}");
                    break;
                //this input shows a result of division
                case 4:
                    Console.WriteLine($"The result of Division is :{secondNumber / firstNumber}");
                    break;
                //outputs a result if a number wasn't 1 - 4
                default: 
                    Console.WriteLine("Invalid Choice please us the numbers 1 - 4 .");
                    break;   
            }
        }
    }
}
