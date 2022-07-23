Console.Write("what is your first name: ");
string? name = Console.ReadLine();

Console.Write("what is your age: ");
string? ageintext = Console.ReadLine();

if (UInt32.TryParse(ageintext, out uint age) && !string.IsNullOrEmpty(name))
{
    string formattedName = CalculateFormattedName(name);
    if(age<21)
    {
        Console.WriteLine($"please wait for {21 - age} years to start this class, {formattedName}");
    }
    else
    {
        Console.WriteLine($"welcome {formattedName}");
    }
}
else
{
    Console.WriteLine("Please enter valid name and age");
}


static string CalculateFormattedName(string name)
{
    if (ValidateName(name, "bob") || ValidateName(name, "sue"))
        return $"Professor {name}";
    else
        return name;
}
    //if (UInt32.TryParse(ageintext, out uint age) && !string.IsNullOrEmpty(name))
    //{
    //    Console.WriteLine($"your name is {name} and age is {age}");
    //    if(ValidateName(name,"bob") || ValidateName(name,"sue"))
    //    {
    //        if(age<21)
    //        {
    //            Console.WriteLine($"please wait for { 21 - age } years to start this class");
    //        }
    //        else
    //        {
    //            Console.WriteLine($"welcome professor {name}");
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("welcome student");
    //    }
    //}
    //else
    //{
    //    Console.WriteLine("Please enter valid name and age");
    //}

static bool ValidateName(string actual, string expected)
{
    return actual.Equals(expected, StringComparison.InvariantCultureIgnoreCase);
}


