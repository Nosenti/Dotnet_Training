using System;

public class MultOrSum
{
	public static void Main(string[] args)
	{
		Console.Write("Enter the value for number 1: ");
		int num1 = Int32.Parse(Console.ReadLine());
		Console.Write("Enter the value for number 2: ");
		int num2 = Int32.Parse(Console.ReadLine());
		if (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 3 == 0 && num2 % 3 == 0)
		{
			Console.WriteLine(num1 * num2);
		}
		else
		{
			Console.WriteLine(num1 + num2);
		}
	}
}

