using System;

public class OddOrEvenNumber
{
	public static void Main(string[] args)
	{
		Console.Write("Enter the number: ");
		int num = Int32.Parse(Console.ReadLine());
		if (num % 2 == 0)
		{
			Console.WriteLine(num + " is a given number");
		}
		else
		{
			Console.WriteLine(num + " is an odd number");
		}
	}
}

