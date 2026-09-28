using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Espresso : CondimentDecorator
    {
        public Espresso(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double price = Size switch
            {
                Size.TALL => 1.00,
                Size.GRANDE => 1.25,
                Size.VENTI => 1.50,
                _ => throw new ArgumentOutOfRangeException(nameof(Size), Size, "Unsupported beverage size.")
            };
            return price + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Espresso";
        }
    }
}
