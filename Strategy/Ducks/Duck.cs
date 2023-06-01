public class Duck
{
	private string name;
	private IFlyable flyableBehaviour;
	private IQuackable quackableBehaviour;
	public Duck()
	{
		this.name = "Duck";
	}
	public Duck(string name)
	{
		this.name = name;
	}
	public Duck(
		string name,
		IFlyable flyableBehaviour,
		IQuackable quackableBehaviour
	) : this(name)
	{
		this.flyableBehaviour = flyableBehaviour;
		this.quackableBehaviour = quackableBehaviour;
	}
	public void display()
	{
		Console.WriteLine("Look, a "+this.name+"!");
	}
	public void performFly()
	{
		if(this.flyableBehaviour == null)
		{
			return;
		}
		this.flyableBehaviour.fly();
	}
	public void performQuack()
	{
		if(this.flyableBehaviour == null)
		{
			return;
		}
		this.quackableBehaviour.quack();
	}

}
