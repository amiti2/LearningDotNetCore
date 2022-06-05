using System;

namespace AlarmClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            while (true)
            {
                if(DateTime.Now == new DateTime(2022, 06, 01, 12, 34, 00))

                Console.Beep(32767, 1000000);
            }
        }
    }
}
