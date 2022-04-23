using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Console.WriteLine("Sisesta oma tulemus");
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                default:
                    Console.WriteLine($"{userResult} on tundamatu väärtus");
                    break;
            }
            Console.WriteLine("Kena päeva!");
            {


            }
        }
    }
}
