using System;

class ParsingToIntegers
{
	public void StringToIntegers()
	{
		try
		{
			Console.Write("Enter a string that represents an integer: ");
			string input = Console.ReadLine();

			int res = int.Parse(input);
			Console.WriteLine("The Converted Integer is {0}", res);
		}
		catch (FormatException)
		{

			Console.WriteLine("Input Error: The input is not a valid integer.");
		}
	}
}