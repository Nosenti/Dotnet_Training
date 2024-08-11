using System;

public class IsLeapYear
{
	public static void Main(string[] args)
	{
		Console.Write("Enter the number of days: ");
		int year = Int32.Parse(Console.ReadLine());
		if (year % 4 == 0 && !(year % 100 == 0 && year % 400 != 0))
		{
			Console.WriteLine("It is a Leap year");
		}
		else
		{
			Console.WriteLine("It is not a leap year");
		}
	}
}

