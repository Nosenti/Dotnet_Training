using System;
class BankAccount
{
	long userId;
	private string firstName;
	private string lastName;
	int balance = 0;

	private BankAccount()
	{

	}

	public BankAccount(string _firstName, string _lastName)
	{
		userId = DateTime.Now.Ticks;
		firstName = _firstName;
		lastName = _lastName;
	}
	public string FirstName
	{
		get { return firstName; }
		set { firstName = value; }
	}

	public string LastName
	{
		get { return lastName; }
		set { lastName = value; }
	}

	public void WithDrawMoney(int amount)
	{
		balance = balance - amount;
	}
	public void DepositMoney(int amount)
	{
		balance = balance + amount;
	}

	public void ShowBalance()
	{
		Console.WriteLine("Your balance is: {0}", balance);
	}
}