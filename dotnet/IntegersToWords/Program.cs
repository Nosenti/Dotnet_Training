using System;

public class IntegersToWords
{
	public static void Main(string[] args)
	{
		string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "None" };
		Console.Write("Enter the value for number 1: ");
		int num = Int32.Parse(Console.ReadLine());
		if (num < 0 || num > 9)
		{
			Console.WriteLine("Number too big");
		}
		else
		{
			Console.WriteLine(num + ": " + words[num]);
		}
	}
}

