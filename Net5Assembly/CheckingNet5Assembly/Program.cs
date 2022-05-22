using System;
using Serilog;
namespace CheckingNet5Assembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
     
            Log.Information("Ah, there you are!");
            Console.ReadLine();
        }
    }
}
