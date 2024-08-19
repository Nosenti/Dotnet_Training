using System;

public class Program
{
	public static void Main(string[] args)
	{
		BankAccount account1 = new BankAccount("Innocent", "Ingabire");
		account1.DepositMoney(1000);
		account1.WithDrawMoney(200);
		account1.FirstName = "Kevin";
		account1.ShowBalance();
		Console.WriteLine(account1.LastName);
		Console.WriteLine(account1.FirstName);
	}
}

