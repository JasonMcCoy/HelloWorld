using System;

class Program
{
	static void Main(string[] args)
	{
		string firstName = "Jason";
		string lastName = "McCoy";
		string errorMSG = "WRONG";

		if (firstName == "McCoy")
		{
			Console.WriteLine(errorMSG);
		}
		else if (firstName == "Jason" && lastName == "McCoy")
		{
			Console.WriteLine(firstName + lastName);
		}

		else
		{
			Console.WriteLine(firstName + lastName);
		}
	}
}
