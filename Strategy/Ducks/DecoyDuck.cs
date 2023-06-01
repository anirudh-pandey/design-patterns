public class DecoyDuck : Duck
{
	public DecoyDuck(
		string name,
		IFlyable flyableBehaviour,
		IQuackable quackableBehaviour
	) : base(name, flyableBehaviour, quackableBehaviour)
	{

	}
}