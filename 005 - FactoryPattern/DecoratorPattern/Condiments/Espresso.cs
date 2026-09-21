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
            return PriceBySize(0.00, 0.00, 0.00) + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Espresso";
        }
    }
}
