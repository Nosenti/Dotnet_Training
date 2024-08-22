using System;

namespace BookLibrary
{
	static class MenuView
	{
		public static void ShowMenu()
		{
			Console.WriteLine("--- Book Library ---");
			Console.WriteLine("1. List all books");
			Console.WriteLine("2. Add new book to library");
			Console.WriteLine("3. Exit Program");
		}
		public static void MenuOptions()
		{
			int option = Int32.Parse(Console.ReadLine());
			OptionService.ProcessOptions(option);
		}
	}
}