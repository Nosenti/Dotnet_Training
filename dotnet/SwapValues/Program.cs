using System;

public class SwapValues
{
	public static void Main(string[] args)
	{
		Console.Write("Enter the value for variable number 1: ");
		int num1 = Int32.Parse(Console.ReadLine());
		Console.Write("Enter the value for variable number 2: ");
		int num2 = Int32.Parse(Console.ReadLine());
		int dummy = num1;
		num1 = num2;
		num2 = dummy;
		Console.WriteLine("After swap. Number 1 is " + num1 + " and number 2 is " + num2);
	}
}

