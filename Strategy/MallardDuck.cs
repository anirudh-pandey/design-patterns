public class MallardDuck : Duck, IFlyable, IQuackable
{
	public MallardDuck(string name) : base(name)
	{

	}

	public void quack()
	{
		Console.WriteLine("Quack!! Quack!!");
	}

	public void fly()
	{
		Console.WriteLine("buf buff(beats wings) and flies away...");
	}
}