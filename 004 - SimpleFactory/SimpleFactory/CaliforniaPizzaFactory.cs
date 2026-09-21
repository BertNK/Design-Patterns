namespace SimpleFactory
{
    internal class CaliforniaPizzaFactory : SimplePizzaFactory
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CaliforniaStyleCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new CaliforniaStylePepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new CaliforniaStyleClamPizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new CaliforniaStyleVeggiePizza();
            }

            return pizza;
        }
    }
}