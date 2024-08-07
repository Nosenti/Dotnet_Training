namespace HelloWorld
{
	class Part1
	{
		public static double ConvertCelciusToFahrenheit(){
			Console.Write("Enter the temperature in Celcius: ");
			int celcius = Int32.Parse(Console.ReadLine());
			double fh = 1.8 * celcius + 32;
			return fh;
		}
		public static void Ascii()
		{
			Console.Write("Type the character: ");
			char chr = char.Parse(Console.ReadLine());

			Console.WriteLine("The ASCII Value of " + chr + " is " + (int)chr);
		}
		public static void Area(){
			Console.Write("Enter Width: ");
			int width = Int32.Parse(Console.ReadLine());
			Console.Write("Enter Height: ");
			int height = Int32.Parse(Console.ReadLine());
			int res = width * height;
			Console.WriteLine("The Area of the rectangle is: ", res);
		}	
		public static void DateFormat(){
			Console.Write("Enter the number of days: ");
			int numDays = Int32.Parse(Console.ReadLine());
			int years = numDays / 365;
			int remainingDays = numDays % 365;
			int weeks = remainingDays / 7;
			int days = remainingDays % 7;

			Console.WriteLine(numDays + "days is equivalent to: " + years + " years, " + weeks + " weeks, and " + days + " days.");
		}
		public static void SwapNumbers()
		{
			Console.Write("Enter the value for variable number 1: ");
			int num1 = Int32.Parse(Console.ReadLine());
			Console.Write("Enter the value for variable number 2: ");
			int num2 = Int32.Parse(Console.ReadLine());
			int dummy = num1;
			num1 = num2;
			num2 = dummy;
			Console.WriteLine("After swap. Number 1 is " + num1 + " and number 2 is " + num2);

		}
	}
}