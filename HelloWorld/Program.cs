using System;

namespace learningCSharp
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("Hello! My name is " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }

     class Program
    {
        static void Main(string[] args)
        {
            var Jason = new Person();

            Jason.firstName = "Jason";
            Jason.lastName = "McCoy";

            Jason.Introduce();
        }
    }

}