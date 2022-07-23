Console.Write("what is your name: ");
string name = Console.ReadLine()!;

if(name.ToLower() == "tim" || name.ToLower() == "timothy")
{
    Console.WriteLine($"Hello { name } Professor");
}
else
{
    Console.WriteLine("welcome student");
}


switch (name.ToLower())
{
    case  "tim" or "timothy":
        Console.WriteLine("Welcome professor: "+ name);
        break;
    default:
        Console.WriteLine("welcome student");
        break;

}

Console.Write("what is your age: ");
int age = Convert.ToInt32(Console.ReadLine());
switch (age)
{
    case > 0 and < 5:
        Console.WriteLine("between 0 - 5");
        break;
    default:
        Console.WriteLine("Age should be between 0 and 5");
        break;
}