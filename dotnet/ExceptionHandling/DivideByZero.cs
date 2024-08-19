using System;

class DivideByZero
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
		catch (DivideByZeroException)
		{

			Console.WriteLine("Math Error: Division by zero is not allowed.");
		}

	}
}