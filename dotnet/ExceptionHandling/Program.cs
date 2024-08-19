using System;

class Program
{
	public static void Main(string[] args)
	{
		try
		{
			int num = -1;
			ValidatePositive val = new ValidatePositive();
			val.ValidatePositiveNumber(num);
			Console.WriteLine("The number is a positive number: {0}", num );
		}
		catch (ArgumentException ex)
		{

			Console.WriteLine($"Error: {ex.Message}");
		}
	}
}
