namespace HelloWorld
{
	class Duck
	{

		public Duck()
		{
		}

		public void quack()
		{
			Console.WriteLine("Quack");
		}
		public void swim()
		{
			Console.WriteLine("Swim");
		}
		public virtual void display()
		{
			Console.WriteLine("display");
		}
		
	}
}