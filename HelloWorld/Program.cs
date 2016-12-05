using System;

namespace learningCSharp
{

	public class Program
	{

		static void Main(string[] args)
		{

			var Autumn = 80; // 70 - 80 degrees
			var Spring = 69; // 50 - 69 degrees
			var Summer = 101; // 101 or higher
			var Winter = 10; // 10 or less than 10 degrees


			if (Autumn >= 70 && Autumn <= 80)
			{
				Console.WriteLine("It's Autumn!!!");
			}
			else if (Spring >= 50 && Spring < 69)
			{
				Console.WriteLine("It's Spring!!!");
			}
			else if (Summer >= 101)
			{
				Console.WriteLine("It's Summer!!!");
			}
			else if (Winter <= 10)
			{
				Console.WriteLine("It's Winter!!!");
			}
			else
			{
				Console.WriteLine("No season detected.");
			}
		
		}
	
	}

}