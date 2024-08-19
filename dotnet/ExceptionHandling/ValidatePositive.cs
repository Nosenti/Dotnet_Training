using System;

class ValidatePositive
{
	public void ValidatePositiveNumber(int number)
	{
		if ( number < 0)
		{
			throw new ArgumentException("The number can not be negative");
		}
	}
}