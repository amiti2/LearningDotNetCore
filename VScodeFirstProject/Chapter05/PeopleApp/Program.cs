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
             bob.FavouriteWonder =(WonderOfTheAncientWorld) 54;//WonderOfTheAncientWorld.LighthouseOfAlexandria;
             
          WriteLine(format:"{0} was born on {1:dddd, d MMMM yyyy}",
                     arg0: bob.name,
                     arg1:bob.dateOfBirth);
          WriteLine(format:"{0}`s favourite wonder is {1} and It`s value is {2}",
                    arg0: bob.name,
                    arg1: bob.FavouriteWonder,
                    arg2: (int)bob.FavouriteWonder);
        
            //var s = File.Open("C://",FileMode.Append);
        }
    }
}