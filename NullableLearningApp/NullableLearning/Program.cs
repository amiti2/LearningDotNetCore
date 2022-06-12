namespace NullableLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int a = 4;
            int b = a++;

            Console.WriteLine($"Value of a is {a} and b is {b}.");
            // b= 4 and a =5

            int c = a;
            int d = ++a;

            //c = 5 and d = 6 and a is 6
            Console.WriteLine($"Value of c is {c} and d is {d} and a is {a}.");

            d = c++; //d = 5 and c =6
            d = ++c; //d = 7 and c =7

            Console.WriteLine($"Value of c is {c} and d is {d}");


        }
    }
}