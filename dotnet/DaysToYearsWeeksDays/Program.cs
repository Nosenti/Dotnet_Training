using System;

public class DaysToYearsWeeksDays
{
	public static void Main(string[] args)
	{
		Console.Write("Enter the number of days: ");
		int numDays = Int32.Parse(Console.ReadLine());
		int years = numDays / 365;
		int remainingDays = numDays % 365;
		int weeks = remainingDays / 7;
		int days = remainingDays % 7;

		Console.WriteLine(numDays + "days is equivalent to: " + years + " years, " + weeks + " weeks, and " + days + " days.");
	}
}

