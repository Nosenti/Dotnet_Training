using System;

public class SortArray
{
	public static void Main(string[] args)
	{
		int[] arr = { 5, 1, 44, 117, 2, 17, 20, 13 };
		for (int i = 0; i < arr.Length; i++)
		{
			for (int j = i + 1; j < arr.Length; j++)
			{
				if (arr[i] > arr[j])
				{
					// swap
					int temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}
		}
		for (int i = 0; i < arr.Length; i++)
		{
			Console.Write(arr[i] + " ");
		}

	}
}

