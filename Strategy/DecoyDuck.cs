public class DecoyDuck : Duck
{
	public DecoyDuck(string name) : base(name)
	{

	}

	public override void quack()
	{
		// does not speaks.
	}

	public override void fly()
	{
		// does not fly.
	}
}