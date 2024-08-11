using System;

public class MultiplicationTable
{
	public static void Main(string[] args)
	{
		for (int i = 1; i < 11; i++)
		{
			for (int j = 1; j < 11; j++)
			{
				Console.Write(i * j);
				Console.Write(" ");
			}
			Console.WriteLine(" ");
		}
	}
}

