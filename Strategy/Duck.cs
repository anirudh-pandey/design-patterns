public class Duck
{
	private string name;
	public Duck()
	{
		this.name = "Duck";
	}
	public Duck(string name)
	{
		this.name = name;
	}
	public void display()
	{
		Console.WriteLine("Look, a "+this.name+"!");
	}

	public virtual void quack()
	{
		Console.WriteLine("Quack!! Quack!!");
	}

	public virtual void fly()
	{
		Console.WriteLine("buf buff(beats wings) and flies away...");
	}
}
