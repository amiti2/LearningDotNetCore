using System;

namespace DelegateAsLambda.Classes
{
    public static class PersonExtensions
    {
        public static void GenerateRandomPerson(this Person person,Func<Person> action)
        {
            var randomPerson = action();
            person.FirstName = randomPerson.FirstName;
            person.LastName = randomPerson.LastName;            
        }

        public static void MutateToUpper(this Person person, Func<string, string> action)
        {
            person.FirstName = action(person.FirstName);
            person.LastName = action(person.LastName);
        }
        public static string Mutate(this Person person, Func<string,string> action)
        {
            return action(person.FirstName +" " + person.LastName);
            
        }
    }
}
