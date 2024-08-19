using System;

class ValidateNumberInRange
{
	public void NumberInRangeValidate()
	{
		Console.Write("Enter number: ");
		int number = int.Parse(Console.ReadLine());
		if (number < 0 || number > 1000)
		{
			throw new ArgumentOutOfRangeException("Number should be between 0 and 1000");
		}else {
			Console.WriteLine("The number is withing the range");
		}
	}
}