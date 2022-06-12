namespace NullableLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To run each example uncomment the subsequent statements

            //PostAndPreIncrementExample();
            //BinaryArithmaticOperatorsExample();
            BooleanLogicalOperatorsExample();

        }

        private static void BooleanLogicalOperatorsExample()
        {
            Boolean a = true;
            Boolean b = false;

            Console.WriteLine($"AND   |{"a ",10} | {"b",10}");
            Console.WriteLine($"a     |{a&a,10} | {a&b,10}");
            Console.WriteLine($"b     |{b&a,11}| {b & b,10}");

            Console.WriteLine("----------------------------------");

            Console.WriteLine($"OR    |{"a ",10}  | {"b",10}");
            Console.WriteLine($"a     |{a|a,10}  | {a|b,10}");
            Console.WriteLine($"b     |{b|a,10}  | {b|b,10}");

            Console.WriteLine("----------------------------------");

            Console.WriteLine($"XOR   |{"a ",10} | {"b",10}");
            Console.WriteLine($"a     |{a^a,10} | {a^b,10}");
            Console.WriteLine($"b     |{b^a,10} | {b^b,10}");

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

            Console.WriteLine($"The result of division by double in divisor is {11/3.0}");

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