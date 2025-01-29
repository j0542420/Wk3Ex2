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
            int addition = 1;
            int subtraction = 2;
            int multiplication = 3;
            int division = 4;

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

            //
            addition = firstNumber + secondNumber;
            subtraction = secondNumber - firstNumber;
            multiplication = secondNumber - firstNumber;
            division = secondNumber - firstNumber;



        }
    }
}
