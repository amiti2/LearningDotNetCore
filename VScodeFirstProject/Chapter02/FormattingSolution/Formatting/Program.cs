using System.Globalization;
using static System.Console;
namespace Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FormattingPractice();
            //ReadKeyPractice();
            PracticeArguments(args);
            PrintArguments();
        }

        private static void PrintArguments()
        {
            WriteLine("Printing argument started");
            foreach (string arg in Environment.GetCommandLineArgs())
            {
                Console.WriteLine(arg);
            }
            WriteLine("Printing argument Finished");
        }
        private static void PracticeArguments(string[] args)
        {
            WriteLine($"There are {args.Length} arguments");

        }
        private static void FormattingPractice()
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            Console.WriteLine(" {0} apples cost {1}", numberOfApples, pricePerApple * numberOfApples);
            Console.WriteLine(format: "{0} apples code {1}", arg0: numberOfApples, arg1: pricePerApple * numberOfApples);
            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");


            decimal value = 12345.6789M; // Be sure to use Decimal for money values. Do not use IEEE-754 types such as float (System.Single) and double (System.Double) as they can only store approximate values.
            Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));

            Console.WriteLine(value.ToString("C3", CultureInfo.CurrentCulture));



            Console.WriteLine(value.ToString("C3", CultureInfo.CreateSpecificCulture("da-DK")));
        }

        static void ReadKeyPractice()
        {
            string name = "amit";
            double age = 39.909090;
            WriteLine($"name is {name: c} and age is {age,-8:N0}");
            Write("Type your name and press enter: ");
            name = ReadLine();

            WriteLine($"your name is {name}");

            Write("Press any key: ");
            ConsoleKeyInfo textadded = ReadKey();
            WriteLine();
            Console.WriteLine(textadded.Key);
            Console.WriteLine(textadded.KeyChar);
            Console.WriteLine(textadded.Modifiers);
        }

    }
}