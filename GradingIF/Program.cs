using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai
            //kui kasutaja sai "A", konsool kuvab "Suurepärane";
            //kui "B", konsool kuvab "Väga hea!";
            //kui "C", konsool kuvab "Hea!";
            //kui "D", konsool kuvab "Rahuldav";
            //kui "E", konsool kuvab "Kasin";
            //kui "F", konsool kuvab "Puudulik";
            //kui kasutaja sisetab midagi muud, konsool kuvab "vale väärtus".

            Console.WriteLine("Sisesta oma tulemus");
            //char - character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
          
                {
                    Console.WriteLine("Suurepärane");
                }
                else if (userResult == 'B')
                {
                    Console.WriteLine("Väga hea!");
                }
                else if (userResult == 'C')
                {
                    Console.WriteLine("Hea!");
                }
                else if (userResult == 'D')
                {
                Console.WriteLine("Rahuldav");
                }
                else if (userResult == 'C')
                {
                Console.WriteLine("Kasin");   
                }
                else if (userResult == 'E')
                {
                Console.WriteLine("Puudulik");
                }
                else
                {
                Console.WriteLine($"{userResult} on vale väärtus");
                    }


            Console.WriteLine("Kena päeva!");
        }
    }
}
