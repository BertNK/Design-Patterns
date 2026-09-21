namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NYPizzaFactory nyFactory = new NYPizzaFactory();
            PizzaStore nyStore = new PizzaStore(nyFactory);
            nyStore.OrderPizza("veggie");

            ChicagoPizzaFactory chicagoFactory = new ChicagoPizzaFactory();
            PizzaStore chicagoStore = new PizzaStore(chicagoFactory);
            chicagoStore.OrderPizza("veggie");

            CaliforniaPizzaFactory californiaFactory = new CaliforniaPizzaFactory();
            PizzaStore californiaStore = new PizzaStore(californiaFactory);
            californiaStore.OrderPizza("cheese");
        }
    }
}