using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            performDuckActions(mallardDuck);

            Duck redheadDuck = new RedheadDuck();
            performDuckActions(redheadDuck);

            Duck decoyDuck = new DecoyDuck();
            performDuckActions(decoyDuck);

            Duck rubberDuck = new RubberDuck();
            performDuckActions(rubberDuck);

            Duck robotDuck = new RobotDuck();
            performDuckActions(robotDuck);
        }

        public static void performDuckActions(Duck duck)
        {
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();
            duck.PerformSwim();
        }
    }
}
