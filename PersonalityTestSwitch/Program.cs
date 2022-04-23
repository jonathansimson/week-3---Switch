using System;

namespace PersonalityTestSwitch
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
            string userColor = Console.ReadLine().ToLower();

            switch(userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                        default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
