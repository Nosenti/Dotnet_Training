using System;

public class NumberSign
{
	public static void Main(string[] args)
	{
		Console.Write("Enter the number: ");
		int num = Int32.Parse(Console.ReadLine());
		if (num == 0)
		{
			Console.WriteLine("The provided number is Zero");
		}
		else if (num < 0)
		{
			Console.WriteLine("The provided number is a negative number");
		}
		else
		{
			Console.WriteLine("The provided number is a positive number");
		}
	}
}

