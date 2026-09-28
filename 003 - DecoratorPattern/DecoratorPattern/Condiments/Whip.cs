using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double price = Size switch
            {
                Size.TALL => 0.10,
                Size.GRANDE => 0.15,
                Size.VENTI => 0.20,
                _ => throw new ArgumentOutOfRangeException(nameof(Size), Size, "Unsupported beverage size.")
            };
            return price + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Whip";
        }
    }
}
