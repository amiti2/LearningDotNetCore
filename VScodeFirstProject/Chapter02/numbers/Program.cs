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
            System.Console.WriteLine(nameof(hexadecimalnotation) +" is "+ hexadecimalnotation.GetType());
            //System.Console.WriteLine(nameof(binarynotation) +"is"+ typeof(binarynotation));

            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");


            System.Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in range {int.MaxValue:N0} and {int.MinValue:N0}");
            System.Console.WriteLine($"Decimal uses {sizeof(decimal)} bytes and can store numbers in range {decimal.MaxValue:N0} and {decimal.MinValue:N0}");
            System.Console.WriteLine($"Double uses {sizeof(double)} bytes and can store numbers in range {double.MaxValue:N0} and {double.MinValue:N0}");


              
        //     int total = 0;
        //     checked
        // {
        //      for(byte i=0;i<byte.MaxValue; i= Convert.ToByte(2))
        //     {
        //         //total +=i;
        //         System.Console.WriteLine(i + " " + total);
        //     }
        // }
           
        }
    }
}
