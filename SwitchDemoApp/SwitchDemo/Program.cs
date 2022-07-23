int age = int.Parse(Console.ReadLine()!);

//switch (age)
//{
//    default:
//        Console.WriteLine("age was not in expected range");
//        break;
//    case >=0 and < 18:
//            Console.WriteLine("you are a child");
//        break;
//    case >= 18 and < 66:
//        Console.WriteLine("you should have a job");
//        break;
//    case >= 66:
//        Console.WriteLine("Hopefully you are retired or retiring soon");
//        break;

//}

switch (age)
{
    default:
        Console.WriteLine("no age");
        break;
    case 0:
        Console.WriteLine("Age is 0");
        break;
    case 1:
        Console.WriteLine("age is 1");
        break;
    case > 2:
        Console.WriteLine("age is greater than 2");
        break;
}