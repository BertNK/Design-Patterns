using DecoratorPattern.Beverages;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeFactory coffeeFactory = new CoffeeMenuFactory();
            coffeeFactory.OrderDrink(CoffeeType.Espresso, Size.TALL);
            coffeeFactory.OrderDrink(CoffeeType.Doppio);
            coffeeFactory.OrderDrink(CoffeeType.Lungo, Size.GRANDE);
            coffeeFactory.OrderDrink(CoffeeType.Macchiato);
            coffeeFactory.OrderDrink(CoffeeType.Corretta);
            coffeeFactory.OrderDrink(CoffeeType.ConPanna, Size.GRANDE);
            coffeeFactory.OrderDrink(CoffeeType.Cappuccino);
            coffeeFactory.OrderDrink(CoffeeType.Americano, Size.VENTI);
            coffeeFactory.OrderDrink(CoffeeType.CaffeLatte);
            coffeeFactory.OrderDrink(CoffeeType.FlatWhite);
            coffeeFactory.OrderDrink(CoffeeType.Romana);
            coffeeFactory.OrderDrink(CoffeeType.Morocchino);
            coffeeFactory.OrderDrink(CoffeeType.Mocha);
            coffeeFactory.OrderDrink(CoffeeType.Bicerin);
            coffeeFactory.OrderDrink(CoffeeType.Breve);
            coffeeFactory.OrderDrink(CoffeeType.RafCoffee);
            coffeeFactory.OrderDrink(CoffeeType.MeadRaf);
            coffeeFactory.OrderDrink(CoffeeType.Galao);
            coffeeFactory.OrderDrink(CoffeeType.CaffeAffogato);
            coffeeFactory.OrderDrink(CoffeeType.ViennaCoffee);
            coffeeFactory.OrderDrink(CoffeeType.Glace);
            coffeeFactory.OrderDrink(CoffeeType.ChocolateMilk);
            coffeeFactory.OrderDrink(CoffeeType.DemiCreme);
            coffeeFactory.OrderDrink(CoffeeType.LatteMacchiato);
            coffeeFactory.OrderDrink(CoffeeType.Freddo);
            coffeeFactory.OrderDrink(CoffeeType.Frappuccino, Size.VENTI);
            coffeeFactory.OrderDrink(CoffeeType.CaramelFrappuccino);
            coffeeFactory.OrderDrink(CoffeeType.Frappe);
            coffeeFactory.OrderDrink(CoffeeType.IrishCoffee);
        }
    }
}
