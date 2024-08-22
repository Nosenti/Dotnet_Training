using System;

namespace BookLibrary
{
	class Book
	{
		//long uniqueId = DateTime.Now.Ticks;
		long bookId;
		string title;
		string authorFirstName;
		string authorLastName;

		private Book()
		{

		}
		public Book(string title_, string authorFirstName_, string authorLastName_)
		{
			bookId = DateTime.Now.Ticks;
			title = title_;
			authorFirstName = authorFirstName_;
			authorLastName = authorLastName_;
		}

		public long BookId
		{
			get { return bookId; }
		}
		public string Title
		{
			get { return title; }
			set { title = value; }
		}
		public string AuthorFirstName
		{
			get { return authorFirstName; }
			set { authorFirstName = value; }
		}
		public string AuthorLastName
		{
			get { return authorLastName; }
			set { AuthorLastName = value; }
		}

	}
}