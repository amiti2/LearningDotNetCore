namespace TuplesApp
{
    class MotorCyclist
    {
        public int NumberOfBikes { get; set; }
        public string? Name { get; set; }

        public string Message => $"{Name} has Ecosport";

        public string this[string index]
        {
            get
            {
                switch (index)
                {
                    case "1":
                        return "amit";
                        
                    case "2":
                        return "Rajan";
                    default:
                        return string.Empty;
                        break;
                }
            }
            set
            {

            }
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                //FirstExample();
                //NamedTupleExample();
                InferingTupleNames();
                //DeconstructingTuples();
                //LearningOptional_Named_Parameters();
            }
            public static void LearningOptional_Named_Parameters()
            {
                var result = Area();
                Console.WriteLine($"Area with default value is {result} ");



                result = Area(2, 2);
                Console.WriteLine($"Area  is {result} ");

                result = Area(1, height: 3);
                Console.WriteLine($"Area  is {result} ");

            }

            public static decimal Area(int length = 1, int bredth = 2, int height = 1)
            {
                return length * bredth * height;
            }

            public static void DeconstructingTuples()
            {
                (string biker, int number) = GetFromNamedTuple();
                Console.WriteLine($"{biker} has {number} bikes");
            }

            public static void InferingTupleNames()
            {
                MotorCyclist motorCyclist = new MotorCyclist { Name = "Amit Irodha", NumberOfBikes = 2 };
                var person = (motorCyclist.Name, motorCyclist.NumberOfBikes);
                Console.WriteLine($"{person.Name} has {person.NumberOfBikes} bikes");

                (string NameOfOwner, int numberOfMotorCycles) amitIrodhaBiker = (motorCyclist.Name, motorCyclist.NumberOfBikes);
                Console.WriteLine($"Again {amitIrodhaBiker.NameOfOwner} has {amitIrodhaBiker.numberOfMotorCycles} bikes");

                Console.WriteLine(motorCyclist.Message[5]);

                Console.WriteLine(motorCyclist["1"]);
                Console.WriteLine(motorCyclist["2"]);

        }

            public static void NamedTupleExample()
            {
                (string name, int number) motorcycleOwner = GetFromNamedTuple();
                Console.WriteLine($"{motorcycleOwner.name} has {motorcycleOwner.number} motorcycles");
            }

            static (string Name, int numbers) GetFromNamedTuple()
            {
                return (Name: "Amit", numbers: 2);
            }

            static void FirstExample()
            {
                (string, int) motorcycleOwner = GetFromTuple();
                Console.WriteLine($"{motorcycleOwner.Item1} has {motorcycleOwner.Item2} motorcycles");
            }

            static (string, int) GetFromTuple()
            {
                return ("amit", 5);
            }
        }

    }