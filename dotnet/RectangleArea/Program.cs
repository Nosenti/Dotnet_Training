using System;

public class RectangleArea
{
	public static void Main(string[] args)
	{
		Console.Write("Enter Width: ");
		int width = Int32.Parse(Console.ReadLine());
		Console.Write("Enter Height: ");
		int height = Int32.Parse(Console.ReadLine());
		int res = width * height;
		Console.WriteLine("The Area of the rectangle is: ", res);
	}
}

