using System;

class EvenNumbers
{
	public int[] GetEvenNumbers(int num)
	{
		List<int> list = new List<int>();
		for(int i = 0; i < num; i++)
		{
			if (i % 2 == 0)
			{
				list.Add(i);
			}
		}

		return list.ToArray();
	}
}