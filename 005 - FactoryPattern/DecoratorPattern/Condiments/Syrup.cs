using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Syrup : CondimentDecorator
    {
        public Syrup(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            return PriceBySize(0.35, 0.40, 0.45) + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Syrup";
        }
    }
}
