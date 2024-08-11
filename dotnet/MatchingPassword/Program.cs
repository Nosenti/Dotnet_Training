using System;

public class MatchingPassword
{
	public static void Main(string[] args)
	{
		Console.Write("Enter the password: ");
		string pass = Console.ReadLine();
		if (pass == "s3cr3t!p@ssw0rd")
		{
			Console.WriteLine("Welcome");
		}
		else
		{
			Console.WriteLine("Wrong Password!");
		}
	}
}

