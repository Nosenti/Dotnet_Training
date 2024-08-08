namespace HelloWorld
{
	class Part2
	{
		public static void OddOrEven()
		{
			Console.Write("Enter the number: ");
			int num = Int32.Parse(Console.ReadLine());
			if (num % 2 == 0){
				Console.WriteLine(num + " is a given number");
			}else {
				Console.WriteLine(num + " is an odd number");
			}
			
		}
		public static void NumberSign()
		{
			Console.Write("Enter the number: ");
			int num = Int32.Parse(Console.ReadLine());
			if (num == 0){
				Console.WriteLine("The provided number is Zero");
			}else if (num < 0){
				Console.WriteLine("The provided number is a negative number");
			}else {
				Console.WriteLine("The provided number is a positive number");
			}
			
		}
		public static void IsLeapYear()
		{
			Console.Write("Enter the number of days: ");
			int year = Int32.Parse(Console.ReadLine());
			if (year % 4 == 0 && !(year % 100 == 0 && year % 400 != 0)){
				Console.WriteLine("It is a Leap year");
			}else {
				Console.WriteLine("It is not a leap year");
			}
			
		}
		public static void MultOrSum()
		{
			Console.Write("Enter the value for number 1: ");
			int num1 = Int32.Parse(Console.ReadLine());
			Console.Write("Enter the value for number 2: ");
			int num2 = Int32.Parse(Console.ReadLine());
			if (num1 % 2 == 0 && num2 % 2 == 0 || num1 % 3 == 0 && num2 % 3 == 0){
				Console.WriteLine(num1 * num2);
			}else{
				Console.WriteLine(num1 + num2);
			}

		}
		public static void ThreeIdenticalNumbers()
		{
			Console.Write("Enter the value for number 1: ");
			int num1 = Int32.Parse(Console.ReadLine());
			Console.Write("Enter the value for number 2: ");
			int num2 = Int32.Parse(Console.ReadLine());
			Console.Write("Enter the value for number 3: ");
			int num3 = Int32.Parse(Console.ReadLine());
			if (num1 == num2 && num2 == num3){
				Console.WriteLine("Numbers are the same");
			}else{
				Console.WriteLine("Numbers are not the same");
			}

		}
		public static void WordsInEnglish()
		{
			string[] words = {"Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "None"};
			Console.Write("Enter the value for number 1: ");
			int num = Int32.Parse(Console.ReadLine());
			if(num < 0 || num > 9)
			{
				Console.WriteLine("Number too big");
			}else{
				Console.WriteLine(num + ": " + words[num]);
			}

		}
		public static void PasswordMatch()
		{
			Console.Write("Enter the password: ");
			string pass = Console.ReadLine();
			if(pass == "s3cr3t!p@ssw0rd")
			{
				Console.WriteLine("Welcome");
			}else{
				Console.WriteLine("Wrong Password!");
			}

		}
	}
}