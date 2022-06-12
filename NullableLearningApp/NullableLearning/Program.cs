namespace NullableLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To run each example uncomment the subsequent statements

            //PostAndPreIncrementExample();
            //BinaryArithmaticOperatorsExample();

        }

        private static void BinaryArithmaticOperatorsExample()
        {
            int e = 11;
            int f = 3;

            Console.WriteLine($"e is {e} and f is {f}");
            Console.WriteLine($"e + f = { e + f }");
            Console.WriteLine($"e - f = { e - f }");
            Console.WriteLine($"e * f = { e * f }");
            Console.WriteLine($"e / f = { e / f }");
            Console.WriteLine($"e % f = { e % f }" );

            double g = 11.0;
            Console.WriteLine($"g is {g:N1} and f is { f }");
            Console.WriteLine($"g / f = { g / f }");

        }

        private static void PostAndPreIncrementExample()
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