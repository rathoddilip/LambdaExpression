using NUnit.Framework;
using LambdaExpression;
using System.Collections.Generic;

namespace NUnitTestProject
{
    public class Tests
    {
        Program program;
        List<Person> personList = new List<Person>();
        public void AddPerson()
        {
            personList.Add(new Person() { SSL = 1, Name = "Harish", Age = 25, Address = "Bangalore" });
            personList.Add(new Person() { SSL = 2, Name = "Kalpana", Age = 20, Address = "Delhi" });
            personList.Add(new Person() { SSL = 3, Name = "Sindhu", Age = 75, Address = "Mumbai" });
            personList.Add(new Person() { SSL = 4, Name = "Dilip", Age = 18, Address = "Karnataka" });
            personList.Add(new Person() { SSL = 5, Name = "Ranya", Age = 15, Address = "Hyderabad" });
        }
        [SetUp]
        public void Setup()
        {
            program = new Program();
        }
        /// <summary>
        /// UC-1 Given person details and set values to person list
        /// </summary>
        [Test]
        public void GivenPersonDetailSetValuesPersonList()
        {
            List<Person> list = program.AddPersonDetail(personList);

            Assert.AreEqual(personList.Count,list.Count);
        }
    }
}