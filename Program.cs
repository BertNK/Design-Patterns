using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();
            mallardDuck.PerformSwim();

            Duck redheadDuck = new RedheadDuck();
            redheadDuck.Display();
            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();
            redheadDuck.PerformSwim();

            Duck decoyDuck = new DecoyDuck();
            decoyDuck.Display();
            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();
            decoyDuck.PerformSwim();

            Duck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();
            rubberDuck.PerformSwim();

            Duck robotDuck = new RobotDuck();
            robotDuck.Display();
            robotDuck.PerformQuack();
            robotDuck.PerformFly();
            robotDuck.PerformSwim();
        }
    }
}