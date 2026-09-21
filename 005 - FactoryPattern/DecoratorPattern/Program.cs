using DecoratorPattern.Beverages;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Espresso, Size.TALL));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Doppio));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Lungo, Size.GRANDE));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Macchiato));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Corretta));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.ConPanna, Size.GRANDE));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Cappuccino));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Americano, Size.VENTI));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.CaffeLatte));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.FlatWhite));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Romana));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Morocchino));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Mocha));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Bicerin));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Breve));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.RafCoffee));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.MeadRaf));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Galao));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.CaffeAffogato));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.ViennaCoffee));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Glace));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.ChocolateMilk));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.DemiCreme));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.LatteMacchiato));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Freddo));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Frappuccino, Size.VENTI));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.CaramelFrappuccino));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.Frappe));
            PrintBeverage(CoffeeFactory.CreateCoffee(CoffeeType.IrishCoffee));
        }

        private static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(
                beverage.GetDescription()
                + " ("
                + beverage.Size
                + ") €"
                + beverage.cost().ToString("0.00"));
        }
    }
}
