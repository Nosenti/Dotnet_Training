using System;

class CombineStrings
{
	public string GetCombinedString(string str1, string str2)
	{
		int maxLength = Math.Max(str1.Length, str2.Length);
		char[] combined = new char[maxLength * 2]; 
		int index = 0;

		for (int i = 0; i < maxLength; i++)
		{
			if (i < str1.Length)
			{
				combined[index++] = str1[i]; 
			}

			if (i < str2.Length)
			{
				combined[index++] = str2[i];
			}
		}

		return new string(combined, 0, index);
	}
}