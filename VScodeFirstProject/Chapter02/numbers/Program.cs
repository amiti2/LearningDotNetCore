using System;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint naturalNumber =23;
            int number = -23;
            int negtetest0 = -0;
            uint testingNumber = 0;
            int f= 4_444;

            int binarynotation = 0b10_10;

            int hexadecimalnotation= 0xA;

            int result = binarynotation+4;
            Console.WriteLine(result);
            System.Console.WriteLine(hexadecimalnotation ==binarynotation);
            System.Console.WriteLine(hexadecimalnotation ==10);
        }
    }
}
