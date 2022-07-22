
if (callfirst() & callsecond())
{
    Console.WriteLine("did not calld");
}

bool callfirst()
{
    Console.WriteLine("first called");
    return false;
}
bool callsecond()
{
    Console.WriteLine("Second called");
    return true;
}

