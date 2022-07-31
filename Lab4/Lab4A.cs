/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Lab#: 4A
 */

using System;

namespace Lab4
{
    class Lab4A
    {
        static void Main(string[] args)
        {
            double eS = 0;
            string uI;

            Console.Write("Enter the score of your exam: ");
            uI = Console.ReadLine();
            eS = Convert.ToDouble(uI);

            Console.Write("Letter grade is: ");

            if (eS > 97)
                Console.Write("A+");
            else if (eS > 94 && eS <= 97)
                Console.Write("A");
            else if (eS > 91 && eS <= 94)
                Console.Write("A-");
            else if (eS > 88 && eS <= 91)
                Console.Write("B+");
            else if (eS > 85 && eS <= 88)
                Console.Write("B");
            else if (eS > 82 && eS <= 85)
                Console.Write("B-");
            else if (eS > 79 && eS <= 82)
                Console.Write("C+");
            else if (eS > 76 && eS <= 79)
                Console.Write("C");
            else if (eS > 73 && eS <= 76)
                Console.Write("C-");
            else if (eS > 70 && eS <= 73)
                Console.Write("D+");
            else if (eS > 67 && eS <= 70)
                Console.Write("D");
            else if (eS > 64 && eS <= 67)
                Console.Write("D-");
            else
                Console.Write("F");



        }
    }
}
