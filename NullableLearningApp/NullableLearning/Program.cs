namespace NullableLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // To run each example uncomment the subsequent statements

            //PostAndPreIncrementExample();
            //BinaryArithmaticOperatorsExample();
            //BooleanLogicalOperatorsExample();
            //ConditionalLogicalOperatorsExample();
            //BitwiseAndShiftOperators();
            //PatternMatchingWithIfStatements();
            BranchingWithSwitchStatement();

        }

        private static void BranchingWithSwitchStatement()
        {
        InitialValue:
            int i  =(new Random()).Next(1,7);

            switch (i)
            {
                default:
                    Console.WriteLine("Default");
                    break;
               

                case 3:
                case 4:
                    Console.WriteLine("Three or Four");
                    goto case 2;


                case 2:
                    Console.WriteLine("Two");
                    goto case 1;

                case 1:
                    Console.WriteLine("One");
                    break;
                case 5:
                    goto InitialValue;
               
            }
        }

        private static void PatternMatchingWithIfStatements()
        {
            object o = 3;
            int j = 4;
            
            if( o is int i)
            {
                Console.WriteLine($"{o} * {j} = {i*j}");
            }
            else
            {
                Console.WriteLine("o is not an int so it can not multiply");
            }
        }

        private static void BitwiseAndShiftOperators()
        {
            int a = 10;
            int b = 6;
            Console.WriteLine($"a & b = {a & b}");
            Console.WriteLine($"a | b = {a | b}");
            Console.WriteLine($"a >> 1 = {a >> 1}");
        }

        private static void ConditionalLogicalOperatorsExample()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine($" a & DoStuff() = { a && DoStuff()}");
            Console.WriteLine($" b & DoStuff() = { b && DoStuff()}");
        }

        private static bool DoStuff()
        {
            Console.WriteLine("I am doing some stuff");
            return true;
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