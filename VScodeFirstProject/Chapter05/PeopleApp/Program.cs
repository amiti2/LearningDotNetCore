using static System.Console;
using Packt.Shared;
namespace PeopleApp
{
    public class Program
    {
        public static void Main()
        {
            //SimpleExample();
            StoringMultipleValuesUsingEnumType();
            //NewExample();
        }

        public static void StoringMultipleValuesUsingEnumType()
        { 
            Person bob = new Person();
            bob.name = "Bob";
            bob.dateOfBirth = new DateTime(2011,4,23);
            bob.BucketList = WondersOfTheAncientWorldFlag.HangingGardensOfBabylon| WondersOfTheAncientWorldFlag.MausoleumAtHalicarnassus;
            WriteLine($"{bob.name}'s bucket list is {bob.BucketList}");
        }

        public static void NewExample()
        {
            var number =1;
            new List<string>
            {
                $"|{number}|",
                $"|{number, -10}|",
                $"|{number, 10}|",
                $"{DateTime.Now:dddd, d MMMM yyyy}",
                $"{"Amit",6 : N2]}"
            }.ForEach(WriteLine);
        }
       
        public static void SimpleExample()
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
        }
    }
}