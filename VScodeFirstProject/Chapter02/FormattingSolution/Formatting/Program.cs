using System.Globalization;
namespace Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal pricePerApple = 0.35M;

            Console.WriteLine(" {0} apples cost {1}",numberOfApples,pricePerApple*numberOfApples);
            Console.WriteLine(format: "{0} apples code {1}",arg0: numberOfApples, arg1: pricePerApple*numberOfApples);
            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");


            decimal value = 12345.6789M; // Be sure to use Decimal for money values. Do not use IEEE-754 types such as float (System.Single) and double (System.Double) as they can only store approximate values.
            Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));

            Console.WriteLine(value.ToString("C3", CultureInfo.CurrentCulture));



            Console.WriteLine(value.ToString("C3", CultureInfo.CreateSpecificCulture("da-DK")));
        }
    }
}