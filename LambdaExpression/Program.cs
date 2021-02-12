using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
   public class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<Person>();
            Program program = new Program();
            program.AddPersonDetail(personList);
            program.RetrieveTopTwoRecordsBelow60(personList);
            program.RetrieveAllRecordsAgeBetween13To18(personList);
        }
        public List<Person> AddPersonDetail(List<Person>personList)
        {
            personList.Add(new Person() { SSL = 1, Name = "Harish", Age = 25, Address = "Bangalore" });
            personList.Add(new Person() { SSL = 2, Name = "Kalpana",Age = 20,Address = "Delhi" });
            personList.Add(new Person() { SSL = 3, Name = "Sindhu", Age = 75, Address = "Mumbai" });
            personList.Add(new Person() { SSL = 4, Name = "Dilip", Age = 18, Address = "Karnataka" });
            personList.Add(new Person() { SSL = 5, Name = "Ranya", Age = 15, Address = "Hyderabad" });

            return personList;
        }
        public void RetrieveTopTwoRecordsBelow60(List<Person> personList)
        {
            var result = personList.FindAll(age => age.Age <= 60).Take(2);
            foreach(Person person in result)
            {
                Console.WriteLine("person Name= "+person.Name +","+ "person age= "+person.Age);
            }
        }
        public void RetrieveAllRecordsAgeBetween13To18(List<Person> personList)
        {
            Console.WriteLine("Retrieve All record from the list for age between 13 to 18 ");
            var result = personList.FindAll(age => age.Age > 13 && age.Age <= 18);
            foreach (Person person in result)
            {
                Console.WriteLine("person Name= " + person.Name + "," + "person age= " + person.Age);
            }
        }
    }
}
