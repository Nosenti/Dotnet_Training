using System;

public class Program
{
	public static void Main(string[] args)
	{
		CombineStrings stringCombiner = new CombineStrings();
		
		string result1 = stringCombiner.GetCombinedString("aaa", "BBB");
		Console.WriteLine(result1); 

		string result2 = stringCombiner.GetCombinedString("good one", "111");
		Console.WriteLine(result2);
	}
}

