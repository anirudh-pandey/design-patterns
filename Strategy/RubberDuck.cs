public class RubberDuck : Duck, IQuackable
{
	public RubberDuck(string name) : base(name)
	{

	}

	public void quack()
	{
		Console.WriteLine("Squeak!! Squeak!!");
	}
}