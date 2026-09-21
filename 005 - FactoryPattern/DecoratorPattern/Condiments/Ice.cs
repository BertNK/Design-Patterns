using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Ice : CondimentDecorator
    {
        public Ice(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return PriceBySize(0.05, 0.10, 0.15) + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Ice";
        }
    }
}
