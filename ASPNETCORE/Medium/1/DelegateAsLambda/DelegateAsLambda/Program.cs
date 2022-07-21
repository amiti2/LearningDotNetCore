using DelegateAsLambda.Classes;
using Faker;

namespace DelegateAsLambda
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var randomPerson = new Person();
            randomPerson.GenerateRandomPerson(
                () =>
                
                    new Person { 
                        FirstName = Name.First(),
                        LastName = Name.Last(),
                    }
                
                );

          

            System.Console.WriteLine($"{ randomPerson.FirstName } { randomPerson.LastName }");

            //randomPerson.Mutate(x => x.Replace(" ","-"));


            System.Console.WriteLine($"{randomPerson.Mutate(x => x.Replace(" ", "-"))}");

            randomPerson.MutateToUpper(x => x.ToUpperInvariant());
            
            System.Console.WriteLine($"{randomPerson.FirstName} {randomPerson.LastName}");
        }
    }
}
