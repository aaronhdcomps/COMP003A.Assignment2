/*
 * Author: Aaron Abramson
 * Course: COMP-003A
 * Purpose: Week 2 Assignment - Programming Basics
 * 
*/

namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("**************************************************");
            Console.WriteLine("Console Section");
            Console.WriteLine("**************************************************");
            Console.WriteLine("\n");
            Console.WriteLine("**************************************************");
            Console.WriteLine("String Section                                    ");
            Console.WriteLine("**************************************************");
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Middle Name: ");
            string middleName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter age in 2023: ");
            string inputAge = Console.ReadLine();
            int yearBorn = 2023 - Convert.ToInt32(inputAge);
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");
            Console.WriteLine("\n");
            Console.WriteLine("**************************************************");
            Console.WriteLine("Math Section                                      ");
            Console.WriteLine("**************************************************");
            Console.Write("Enter an integer for integer1: ");
            string inputInteger1 = Console.ReadLine();
            int integer1 = Convert.ToInt32(inputInteger1);
            Console.Write("Enter an integer for integer2: ");
            string inputInteger2 = Console.ReadLine();
            int integer2 = Convert.ToInt32(inputInteger2);
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");

        }
    }
}