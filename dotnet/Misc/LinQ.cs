// List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
// List<int> evenNumbers = new List<int>();

// foreach (int number in numbers)
// {
// 	if (number % 2 == 0)
// 	{
// 		evenNumbers.Add(number);
// 	}
// }

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

IEnumerable<int> evenNumbers = from number in numbers
							   where number % 2 == 0
							   select number;