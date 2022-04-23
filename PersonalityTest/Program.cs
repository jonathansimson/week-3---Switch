using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal sisestada oma lemmikvärv;
            //kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline"; konsool kuvab "oled looduse sõber";
            // kui kasutja sisestab midagi muud, konsool kuvab "oled {userColor} ükssarvik";

            Console.WriteLine("Sisesta oma lemmikvärv");
            string usercolor = Console.ReadLine();

            if(usercolor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if(usercolor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if(usercolor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else
            {
                Console.WriteLine($"Oled {usercolor} ükssarvik.");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
