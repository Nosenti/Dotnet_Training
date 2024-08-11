using System;

public class TemperatureConversion
{
	public static void Main(string[] args)
	{
		Console.Write("Enter the temperature in Celcius: ");
		int celcius = Int32.Parse(Console.ReadLine());
		double fh = 1.8 * celcius + 32;
		Console.WriteLine($"The temperature in Fahrenheit is: {fh}");
	}
}

