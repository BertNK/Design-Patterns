using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Water : CondimentDecorator
    {
        public Water(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return PriceBySize(0.30, 0.35, 0.40) + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Water";
        }
    }
}
