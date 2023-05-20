public class Program
{
	static void Main(string[] args)
	{
		Duck duck = new();
		duck.display();
		duck.quack();
		duck.fly();

		RubberDuck rubberDuck = new("Rubber Duck");
		rubberDuck.display();
		rubberDuck.quack();
		rubberDuck.fly();

		MallardDuck mallardDuck = new("Mallard Duck");
		mallardDuck.display();
		mallardDuck.quack();
		mallardDuck.fly();

		DecoyDuck decoyDuck = new("Decoy Duck");
		decoyDuck.display();
		decoyDuck.quack();
		decoyDuck.fly();


	}
}
