using static System.Console;
using Packt.Shared;
namespace PeopleApp
{
    public class Program
    {
        public static void Main()
        {
            Person bob = new Person();
             bob.name = "Bob";
             bob.dateOfBirth = new DateTime(2011,4,23);
          WriteLine(format:"{0} was born on {1:dddd, d MMMM yyyy}",
                     arg0: bob.name,
                     arg1:bob.dateOfBirth);

            //var s = File.Open("C://",FileMode.Append);
        }
    }
}