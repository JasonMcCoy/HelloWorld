using System;
using HelloWorld.Math;

namespace learningCSharp.Math
{
	public enum shippingMethods
	{

		twoDayShipping = 2,
		threeDayShipping = 3,
		groundShipping = 5

	}

	class Program
	{
		static void Main(string[] args)
		{
			var Jason = new Person();

			Jason.firstName = "Jason";
			Jason.lastName = "McCoy";

			Jason.Introduce();

			var calculator = new Calculator();
			var total = calculator.Add(1, 2);

			Console.WriteLine(total);


			// Arrays using integers
			var numbers = new int[3];
			numbers[0] = 1;
			numbers[1] = 2;
			numbers[2] = 3;

			Console.WriteLine(numbers[0]);
			Console.WriteLine(numbers[1]);
			Console.WriteLine(numbers[2]);


			// Arrays using strings
			var names = new string[3];
			names[0] = "Jason";
			names[1] = "Irene";
			names[2] = "Josh";

			Console.WriteLine(names[0]);
			Console.WriteLine(names[1]);
			Console.WriteLine(names[2]);


			// Verbatim string
			var someText = @"Hi x, please do the following tasks today:
			1. Work on x
            		2. Then work on y
			3. Then finish with z";

			Console.WriteLine(someText);

			var firstName = "Jason";
			var lastName = "McCoy";

			var myFullName = string.Format("My full name is {0}, {1}", firstName, lastName);
			Console.WriteLine(myFullName);


			var twoDayShipping = shippingMethods.twoDayShipping;
			var threeDayShipping = shippingMethods.threeDayShipping;
			var fiveDayShipping = shippingMethods.groundShipping;       

			Console.WriteLine("Hi, your shipment will arrive in {0} days.", (int)twoDayShipping);

		}
	}
}