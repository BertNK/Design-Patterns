using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // mallardduck
            Duck mallardDuck = new MallardDuck();
            mallardDuck.SetQuackBehavior(new Squeak());
            mallardDuck.SetSwimBehavior(new SwimNoWay());
            mallardDuck.SetFlyBehavior(new FlyNoWay());
            PerformDuckActions(mallardDuck);

            // redheadduck
            Duck redheadDuck = new RedheadDuck();
            redheadDuck.SetQuackBehavior(new RegularQuack());
            redheadDuck.SetFlyBehavior(new FlyWithWings());
            redheadDuck.SetSwimBehavior(new SwimWithFin());
            PerformDuckActions(redheadDuck);

            // decoyduck 
            Duck decoyDuck = new DecoyDuck();
            decoyDuck.SetQuackBehavior(new MuteQuack());
            decoyDuck.SetFlyBehavior(new FlyNoWay());
            decoyDuck.SetSwimBehavior(new Floating());
            PerformDuckActions(decoyDuck);

            // rubberduck
            Duck rubberDuck = new RubberDuck();
            rubberDuck.SetQuackBehavior(new Squeak());
            rubberDuck.SetFlyBehavior(new FlyNoWay());
            rubberDuck.SetSwimBehavior(new Floating());
            PerformDuckActions(rubberDuck);

            // robotduck
            Duck robotDuck = new RobotDuck();
            robotDuck.SetQuackBehavior(new RobotQuack());
            robotDuck.SetFlyBehavior(new FlyWithJetpack());
            robotDuck.SetSwimBehavior(new SwimNoWay());
            PerformDuckActions(robotDuck);
        }

        public static void PerformDuckActions(Duck duck)
        {
            duck.Display();
            duck.PerformQuack();
            duck.PerformSwim();
            duck.PerformFly();
        }
    }
}