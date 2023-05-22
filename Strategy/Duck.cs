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
}
