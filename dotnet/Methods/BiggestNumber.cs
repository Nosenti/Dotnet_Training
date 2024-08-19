using System;

class BiggestNumber
{
	public int GetBiggestNumber(int[] arr)
	{
		int biggestNumber = arr[0];

		for (int i = 1; i < arr.Length; i++)
		{
			if (arr[i] > biggestNumber)
			{
				biggestNumber = arr[i];
			}
		}
		return biggestNumber;
	}
}