using System;

namespace HelloWorld.Math
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
}
