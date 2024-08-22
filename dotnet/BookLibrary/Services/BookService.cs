using System;

namespace BookLibrary
{
	class BookService
	{
		public static List<Book> books = new List<Book>();
		static IEnumerable<Book> getListBooks()
		{
			foreach(var book in books)
			{
				yield return book;
			}
		}
		public static void AddBook(string title, string authorFirstName, string authorLastName)
		{
			Book newBook = new Book(title, authorFirstName, authorLastName);
			books.Add(newBook);
			Console.WriteLine("Book Added");
		}

		public static void ListAllBooks()
		{
			foreach (var book in getListBooks())
			{
				Console.WriteLine(book.Title);
			}
		}

	}
}