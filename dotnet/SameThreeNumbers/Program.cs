using System;

public class ThreeIdenticalNumbers
{
	public static void Main(string[] args)
	{
		Console.Write("Enter the value for number 1: ");
		int num1 = Int32.Parse(Console.ReadLine());
		Console.Write("Enter the value for number 2: ");
		int num2 = Int32.Parse(Console.ReadLine());
		Console.Write("Enter the value for number 3: ");
		int num3 = Int32.Parse(Console.ReadLine());
		if (num1 == num2 && num2 == num3)
		{
			Console.WriteLine("Numbers are the same");
		}
		else
		{
			Console.WriteLine("Numbers are not the same");
		}
	}
}

