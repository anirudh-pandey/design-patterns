public class MallardDuck : Duck
{
	public MallardDuck(
		string name,
		IFlyable flyableBehaviour,
		IQuackable quackableBehaviour
	) : base(name, flyableBehaviour, quackableBehaviour)
	{

	}
}