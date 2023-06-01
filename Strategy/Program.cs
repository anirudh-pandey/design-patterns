public class Program
{
	static void Main(string[] args)
	{
		Duck duck = new();
		duck.display();

		MallardDuck mallardDuck = new(
			"Mallard Duck",
			new FlyWithWings(),
			new Quack()
		);
		mallardDuck.display();
		mallardDuck.performFly();
		mallardDuck.performQuack();
		
		RubberDuck rubberDuck = new(
			"Rubber Duck",
			new Flightless(),
			new Squeak()
		);
		rubberDuck.display();
		rubberDuck.performFly();
		rubberDuck.performQuack();

		DecoyDuck decoyDuck = new(
			"Decoy Duck",
			new Flightless(),
			new Mute()
		);
		decoyDuck.display();
		decoyDuck.performFly();
		decoyDuck.performQuack();


	}
}
