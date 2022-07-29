/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Lab#: 4C
 */

using System;

namespace Lab4
{
    class Lab4C
    {
        static void Main(string[] args)
        {
            string uI;
            double input = 0, answer = 0;
            int choice = 0;

            Console.WriteLine("Welcome!");
            Console.Write("Please input a number: ");
            uI = Console.ReadLine();
            // input = Convert.ToDouble(uI);
            input = Convert.ToDouble(uI);
            Console.WriteLine(" ");

            Console.WriteLine("What would you like to do to this number: ");
            Console.WriteLine("0- Get the additive inverse of the number");
            Console.WriteLine("1- Get the reciprocal of the number");
            Console.WriteLine("2- Square the number");
            Console.WriteLine("3- Cube the number");
            Console.WriteLine("4- Exit the program");

            Console.WriteLine(" ");
            uI = Console.ReadLine();
            choice = Convert.ToInt32(uI);
            Console.WriteLine(" ");

            switch (choice)
            {
                case 0:
                    {
                        if (input < 0)
                            answer = input / -1;
                        else
                            answer = input * -1;

                        Console.WriteLine("The additive inverse of " + input + " is " + answer);
                        break;
                    }
                case 1:
                    {
                        answer = 1.0d / input;
                        Console.WriteLine("The reciprocal of " + input + " is " + answer);
                        break;
                    }
                case 2:
                    {
                        answer = input * input;
                        if (input % 1 == 0)
                            Console.WriteLine("The square of " + input + ".0 is " + answer + ".0");
                        else
                            Console.WriteLine("The square of " + input + " is " + answer);
                        break;
                    }
                case 3:
                    {
                        answer = input * input * input;
                        if (input % 1 == 0)
                            Console.WriteLine("The cube of " + input + ".0 is " + answer + ".0");
                        else
                            Console.WriteLine("The cube of " + input + " is " + answer);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thank you, goodbye!");
                        break;
                    }
                default:
                    Console.WriteLine("Invalid input, please try again!");
                    break;
            }







        }
    }
}
