public class RubberDuck : Duck
{
	public RubberDuck(string name) : base(name)
	{

	}

	public override void quack()
	{
		Console.WriteLine("Squeak!! Squeak!!");
	}

	public override void fly()
	{
		// does not fly.
	}
}