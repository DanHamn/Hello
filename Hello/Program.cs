using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name:");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep di you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());




            Console.WriteLine("Hello, " + name + "!");
            if(hoursOfSleep >= 7.5 && hoursOfSleep <= 8.5)
            {
                Console.WriteLine("You are well rested.");
            }
            else if(hoursOfSleep < 7.5)
            {
                Console.WriteLine("You need more sleep.");
            }
            else if(hoursOfSleep > 8.5)
            {
                Console.WriteLine("You got to much sleep.");
            }
        }
    }
}
