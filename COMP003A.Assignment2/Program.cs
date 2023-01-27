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
            //Console segment------------------------------------------------------
            Console.WriteLine("**************************************************"); 
            Console.WriteLine("Console Section");
            Console.WriteLine("**************************************************");
            Console.Title = "COMP-003A - Assignment 2";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            //---------------------------------------------------------------------

            //String segment-------------------------------------------------------
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
            int yearBorn = 2023 - Convert.ToInt32(inputAge);//---------------------<<<|Data type conversion from string to integer.|
            Console.WriteLine($"Hello, {firstName} {middleName} {lastName}. You were born in {yearBorn}.");//<<<|String uses interpolation.(Starts with $ prior to quotation|
            Console.WriteLine("\n");
            //---------------------------------------------------------------------

            //Math segment---------------------------------------------------------
            Console.WriteLine("**************************************************");
            Console.WriteLine("Math Section                                      ");
            Console.WriteLine("**************************************************");
            Console.Write("Enter an integer for integer1: ");
            int integer1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter an integer for integer2: ");
            int integer2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{integer1} + {integer2} = {integer1 + integer2}");
            Console.WriteLine($"{integer1} - {integer2} = {integer1 - integer2}");
            Console.WriteLine($"{integer1} * {integer2} = {integer1 * integer2}");
            Console.WriteLine($"{integer1} / {integer2} = {integer1 / integer2}");
            Console.WriteLine($"{integer1} % {integer2} = {integer1 % integer2}");
            Console.WriteLine("\n");
            //---------------------------------------------------------------------

            //Circle Area Segment--------------------------------------------------
            Console.WriteLine("**************************************************");
            Console.WriteLine("Circle Area & Circumference Calculator Section    ");
            Console.WriteLine("**************************************************");
            Console.Write("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;



        }
    }
}