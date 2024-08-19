using System;

public class SumOfIntegersWithinRange
{
	public static void Main(string[] args)
	{
		Console.Write("Enter the first integer: ");
		int int1 = Int32.Parse(Console.ReadLine());
		Console.Write("Enter the second integer: ");
		int int2 = Int32.Parse(Console.ReadLine());
		int sum = 0;
		int count = 0;
		for(int i = int1; i <= int2; i++){
			sum = sum + i;
			count++;
		}
		Console.WriteLine("First number: " + int1);
		Console.WriteLine("Second number: " + int2);
		Console.WriteLine("Sum: " + sum);
		Console.WriteLine("Average: " + (sum / count));
	}
}

