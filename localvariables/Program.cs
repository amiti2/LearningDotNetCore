using System;
    #nullable enable

namespace localvariables
{
     class Address
{
public string? Building;
public string Street;
public string City;
public string Region;
}
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine($"default value of string is {default(string) }");
           System.Console.WriteLine($"default value of integer is {default(int) }");
           System.Console.WriteLine($"default value of boolean is {default(bool) }");
           System.Console.WriteLine($"default value of double is {default(double) }");
           System.Console.WriteLine($"default value of DateTime is {default(DateTime) }");
           if(default(DateTime) == DateTime.MinValue)
           {
                Console.WriteLine("default date time value is equal to date time min value");
           }   

           int? edge = 0;   
           int h;     
        }
    }
}
