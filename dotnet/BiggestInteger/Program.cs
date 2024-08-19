using System;
public class BiggestNumber
{
	public static void Main(string[] args)
	{
		int[] arr = { 1, 5, 9, 2, 5 };
		int biggestNumber = arr[0];
		for (int i = 1; i < arr.Length; i++)
		{
			if (arr[i] > biggestNumber)
			{
				biggestNumber = arr[i];
			}
		}
		Console.WriteLine("The biggest number: {0}", biggestNumber);
	}
}

