using System;

public class AsciiValue
{
	public static void Main(string[] args)
	{
		Console.Write("Type the character: ");
		char chr = char.Parse(Console.ReadLine());

		Console.WriteLine("The ASCII Value of " + chr + " is " + (int)chr);
	}
}

