using System;

class DivideTwoNumbers
{
	public void DivideNumbers()
	{
		try
		{
			Console.Write("Enter the fisrt number: ");
			int num1 = int.Parse(Console.ReadLine());
			Console.Write("Enter the second number: ");
			int num2 = int.Parse(Console.ReadLine());
			double result = num1 / num2;
			Console.WriteLine($"Result: {num1} / {num2} = {result}");
		}
		catch (FormatException)
		{

			Console.WriteLine("Math Error: Some of the provided inputs are not numeric");
		}
		
	}
}