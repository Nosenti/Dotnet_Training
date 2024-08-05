namespace HelloWorld
{
	class Book
	{
		public string title;
		public string author;
		public int pages;
		private int rating;

		public Book(string aTitle, string author, int pages, int rating)
		{
			title = aTitle;
			this.author = author;
			this.pages = pages;
			Rating = rating;
		}

		public int Rating {
			get { return rating; }
			set { 
				if (value > 5 || value < 0)
				{
					rating = 0;
				} else {
					rating = value;
				}
			}
		}
	}
}