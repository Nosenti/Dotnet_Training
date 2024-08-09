namespace HelloWorld
{
	class Part3
	{
		public static void MultiplicationTableOfTen()
		{
			
			for(int i = 1; i < 11; i++){
				for(int j = 1; j < 11; j++){
					Console.Write(i * j);
					Console.Write(" ");
				}
				Console.WriteLine(" ");
			}
		}
		public static void BiggestNumber()
		{
			int[] arr = { 1, 5, 9, 2, 5};
			int biggestNumber = arr[0];
			for(int i = 1; i < arr.Length; i++){
				if (arr[i] > biggestNumber) {
					biggestNumber = arr[i];
				}
			}
			Console.WriteLine("The biggest number: {0}", biggestNumber);

		}
		public static void SortArray()
		{
			int[] arr = { 5, 1, 44, 117, 2, 17, 20, 13 };
			for(int i = 0; i < arr.Length; i++){
				for(int j = i + 1; j < arr.Length; j++){
					if(arr[i] > arr[j]){
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
		public static void EvenNumbersToHundred()
		{
			for(int i = 0; i <= 100; i++){
				if (i % 2 == 0){
					Console.WriteLine(i);
				}
				
			}

		}
		public static void OddNumbersToFiveHundred()
		{
			

		}
		public static void ChristmastTree()
		{
			

		}
		public static void IntegerStats()
		{
			

		}
		public static void ReverseNumber()
		{
			

		}
		public static void PrintAllExceptThreeNumbers()
		{

		}
		public static void FirstAndLastDigits()
		{

		}
		public static void SumOfAllDigits()
		{

		}
		public static void SumOfEvenNumbers()
		{

		}
		public static void SplitPositiveAndNegativeNumbers()
		{

		}
	}
}