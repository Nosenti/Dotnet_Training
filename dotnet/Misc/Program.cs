using System;

class Animal
{
	public string ScientificName { get; set; }
	public void eat()
	{
		Console.WriteLine("Animal eating...");
	}

}

class Cat : Animal
{
	string Breed { get; set; }
}
class Program
{
	public static void Main(string[] args)
	{
		Animal an1 = new Cat();
		// Dog d1 = new Animal();
		IEnumerable<Animal> animals = new List<Cat>();
		an1.eat();
		// d1.eat();

		Action<Animal> animalAction = (a) => Console.WriteLine(a.ScientificName);
		Action<Cat> catAction = animalAction;

	}
}

