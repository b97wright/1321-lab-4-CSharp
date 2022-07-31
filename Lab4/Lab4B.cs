/*
    Class: 1321L
    Section: Section W#1 C#
    Term: Spring 2022
    Instructor: Gayathri Yella
    Name: Brandon Wright
    Assignment#: Assignment3B
*/

using System;

namespace Assignment3
{
    class Assignment3B
    {
        static void Main(string[] args)
        {
            string uI;
            char weekDay, time;


            Console.WriteLine("[Instructor Scheduler]");
            Console.Write("What day of the week is it? ");
            uI = Console.ReadLine();
            weekDay = Convert.ToChar(uI);

            Console.Write("What time of day? ");
            uI = Console.ReadLine();
            time = Convert.ToChar(uI);

            switch (weekDay)
            {
                case 'M':
                    if (time == 'a')
                    {
                        Console.WriteLine("On Monday Morning, you’ll be teaching C++, section E04!");
                        break;
                    }
                    else if (time == 'p')
                    {
                        Console.WriteLine("On Monday Evening, you’ll be teaching Java, section J02!");
                        break;
                    }
                    Console.WriteLine("That’s not a valid day or time!!");
                    break;

                case 'T':
                    if (time == 'a')
                    {
                        Console.WriteLine("On Tuesday Morning, you’ll be holding office hours!");
                        break;
                    }
                    else if (time == 'p')
                    {
                        Console.WriteLine("On Tuesday Evening, you’ll be teaching C#, section W#1!");
                        break;
                    }
                    Console.WriteLine("That’s not a valid day or time!!");
                    break;

                case 'W':
                    if (time == 'a')
                    {
                        Console.WriteLine("On Wednesday Evening, you’ll be teaching C#, section #02!");
                        break;
                    }
                    else if (time == 'p')
                    {
                        Console.WriteLine("On Wednesday Afternoon, you’ll have some free time!");
                        break;
                    }
                    Console.WriteLine("That’s not a valid day or time!!");
                    break;

                case 'R':
                    if (time == 'a')
                    {
                        Console.WriteLine("On Thursday Morning, you’ll be holding office hours!");
                        break;
                    }
                    else if (time == 'p')
                    {
                        Console.WriteLine("On Thursday Evening, you’ll be teaching C++, section WE3!");
                        break;
                    }
                    Console.WriteLine("That’s not a valid day or time!!");
                    break;

                case 'F':
                    if (time == 'a')
                    {
                        Console.WriteLine("On Friday Morning, you’ll be teaching Java, section WJ3!");
                        break;
                    }
                    else if (time == 'p')
                    {
                        Console.WriteLine("On Friday Evening, you’ll have some free time!");
                        break;
                    }
                    Console.WriteLine("That’s not a valid day or time!!");
                    break;
                default:
                    Console.WriteLine("That’s not a valid day or time!!");
                    break;

            }

        }
    }
}
