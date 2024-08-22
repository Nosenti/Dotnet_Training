using System;

namespace BookLibrary
{
	static class OptionService
	{
		public static void TakeBookInputs()
		{
			Console.WriteLine("Add new book: ");
			Console.WriteLine("Enter book title: ");
			string title = Console.ReadLine();
			Console.WriteLine("Enter author first name: ");
			string firstName = Console.ReadLine();
			Console.WriteLine("Enter author last name: ");
			string lastName = Console.ReadLine();
			BookService.AddBook(title, firstName, lastName);
		}
		public static void ProcessOptions(int option)
		{
			switch(option)
			{
				case 1:
					BookService.ListAllBooks();
					break;
				case 2:
					TakeBookInputs();
					break;
				case 3:
					Environment.Exit(0);
					break;
				default:
					Console.WriteLine("Incorrect option");
					break;
			}
		}
	}
}