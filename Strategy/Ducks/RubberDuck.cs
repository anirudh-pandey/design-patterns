public class RubberDuck : Duck, IQuackable
{
	public RubberDuck(
		string name,
		IFlyable flyableBehaviour,
		IQuackable quackableBehaviour
	) : base(name, flyableBehaviour, quackableBehaviour)
	{

	}

	public void quack()
	{
		Console.WriteLine("Squeak!! Squeak!!");
	}
}